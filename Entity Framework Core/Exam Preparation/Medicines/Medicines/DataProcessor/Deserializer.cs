namespace Medicines.DataProcessor
{
    using Invoices.Extensions;
    using Medicines.Data;
    using Medicines.Data.Models;
    using Medicines.Data.Models.Enums;
    using Medicines.DataProcessor.ImportDtos;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid Data!";
        private const string SuccessfullyImportedPharmacy = "Successfully imported pharmacy - {0} with {1} medicines.";
        private const string SuccessfullyImportedPatient = "Successfully imported patient - {0} with {1} medicines.";

        public static string ImportPatients(MedicinesContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            
            var patients = new HashSet<Patient>();

            var patientsDto = jsonString.DeserializeFromJson<ImportPatientDto[]>();

            foreach (var patientDto in patientsDto)
            {
                if (!IsValid(patientDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                var patient = new Patient()
                {
                    FullName = patientDto.FullName,
                    AgeGroup = (AgeGroup)patientDto.AgeGroup,
                    Gender = (Gender)patientDto.Gender,
                };

                foreach (var medicineId in patientDto.Medicines)
                {
                    if (patient.PatientsMedicines.Any(pm => pm.MedicineId == medicineId))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    patient.PatientsMedicines.Add(new PatientMedicine
                    {
                        MedicineId = medicineId
                    });

                }
                patients.Add(patient);
                sb.AppendLine(string.Format(SuccessfullyImportedPatient, patient.FullName, patient.PatientsMedicines.Count));
            }
            context.Patients.AddRange(patients);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportPharmacies(MedicinesContext context, string xmlString)
        {
            
            StringBuilder sb = new();
            var pharmacies = new HashSet<Pharmacy>();
            var pharmaciesDtos = XmlSerializationExtension.DeserializeToXml<ImportPharmacyDto[]>(xmlString, "Pharmacies");

            foreach(var pharmacyDto in pharmaciesDtos)
            {
                if(!IsValid(pharmacyDto) || (pharmacyDto.IsNonStop != "false" && pharmacyDto.IsNonStop != "true"))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
               
                var pharmacy = new Pharmacy()
                {
                    IsNonStop = bool.Parse(pharmacyDto.IsNonStop),
                    Name = pharmacyDto.Name,
                    PhoneNumber = pharmacyDto.PhoneNumber,
                };

                foreach(var medicine in pharmacyDto.Medicines)
                {
                   
                    if (!IsValid(medicine) || string.IsNullOrWhiteSpace(medicine.ProductionDate) || string.IsNullOrWhiteSpace(medicine.ExpiryDate))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    DateTime productionDate = DateTime.ParseExact(medicine.ProductionDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    DateTime expiryDate = DateTime.ParseExact(medicine.ExpiryDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    if (productionDate >= expiryDate || medicine.Category < 0 || medicine.Category > 4 
                        || pharmacy.Medicines.Any(m => m.Name == medicine.Name && m.Producer == medicine.Producer))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
               
                    pharmacy.Medicines.Add(new Medicine()
                    {
                        Category = (Category)medicine.Category,
                        Name = medicine.Name,
                        Price = medicine.Price,
                        ProductionDate = productionDate,
                        ExpiryDate = expiryDate,
                        Producer = medicine.Producer,
                    });
                }
                pharmacies.Add(pharmacy);
                sb.AppendLine(string.Format(SuccessfullyImportedPharmacy, pharmacy.Name, pharmacy.Medicines.Count()));
            }
            context.Pharmacies.AddRange(pharmacies);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}
