using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    public class UniversityRepository : IRepository<IUniversity>
    {
        private readonly List<IUniversity> universities;
        public UniversityRepository()
        {
            this.universities = new List<IUniversity>();
        }
        public IReadOnlyCollection<IUniversity> Models => this.universities.AsReadOnly();

        public void AddModel(IUniversity model)
        {
            this.universities.Add(model);
        }

        public IUniversity FindById(int id)
        {
            return this.universities.FirstOrDefault(x => x.Id == id);
        }

        public IUniversity FindByName(string name)
        {
            return this.universities.FirstOrDefault(x =>x.Name == name); 
        }
    }
}
