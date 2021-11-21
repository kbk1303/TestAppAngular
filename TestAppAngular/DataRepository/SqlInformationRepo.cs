using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAppAngular.Models;

namespace TestAppAngular.DataRepository
{
    public class SqlInformationRepo : IInformationRepo
    {
        private readonly Informationcontext context;
        public SqlInformationRepo(Informationcontext context)
        {
            this.context = context;
        }
        public IEnumerable<Information> FetchAllInformations()
        {
            return this.context.Informations.ToList();
        }

        public Information GetInformationById(int id)
        {
            return this.context.Informations.FirstOrDefault(p => p.Id == id);
        }
    }
}
