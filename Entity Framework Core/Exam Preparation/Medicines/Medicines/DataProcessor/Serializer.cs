namespace Medicines.DataProcessor
{
    using Invoices.Extensions;
    using Medicines.Data;
    using Medicines.Data.Models;
    using Medicines.Data.Models.Enums;
    using Medicines.DataProcessor.ExportDtos;
    using Newtonsoft.Json;
    using System.Globalization;

    public class Serializer
    {
        public static string ExportPatientsWithTheirMedicines(MedicinesContext context, string date)
        {
            
            var patients = context.Patients
                .Where(p => p.PatientsMedicines
                .Any(pm => pm.Medicine.ProductionDate >= DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture)))
                .ToArray()
                .Select(p => new ExportPatientDto
                {
                    Gender = p.Gender.ToString().ToLower(),
                    Name = p.FullName,
                    AgeGroup = p.AgeGroup.ToString(),
                    Medicines = p.PatientsMedicines
                   .Where(pm => pm.Medicine.ProductionDate > DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture))
                   .OrderByDescending(pm => pm.Medicine.ExpiryDate)
                   .ThenBy(pm => pm.Medicine.Price)
                   .Select(pm => new ExportMedicineDto()
                    {
                        Category = pm.Medicine.Category.ToString().ToLower(),
                        Name = pm.Medicine.Name,
                        Price = pm.Medicine.Price.ToString("f2"),
                        Producer = pm.Medicine.Producer,
                        BestBefore = pm.Medicine.ExpiryDate.ToString("yyyy-MM-dd",CultureInfo.InvariantCulture)
                    })                  
                    .ToArray()
                })
                .OrderByDescending(p => p.Medicines.Length)
                .ThenBy (p => p.Name)
                .ToArray();

            return XmlSerializationExtension.SerializeToXml<ExportPatientDto[]>(patients, "Patients");
        }

        public static string ExportMedicinesFromDesiredCategoryInNonStopPharmacies(MedicinesContext context, int medicineCategory)
        {
            var medicines = context.Medicines
                .Where(m => m.Category == (Category)medicineCategory && m.Pharmacy.IsNonStop == bool.Parse("true"))
                .ToArray()
                .Select(m => new
                {
                    m.Name,
                    Price = m.Price.ToString("f2"),
                    Pharmacy = new
                    {
                        m.Pharmacy.Name,
                        m.Pharmacy.PhoneNumber
                    }   
                    
                })
                .OrderBy(m => m.Price)
                .ThenBy(m => m.Name)
                .ToArray();

            return JsonConvert.SerializeObject(medicines, Formatting.Indented);
        }
    }
}
