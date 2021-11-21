using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAppAngular.Models;

namespace TestAppAngular.DataRepository
{
    public interface IInformationRepo
    {
        bool SaveChanges();
        IEnumerable<Information> FetchAllInformations();
        Information GetInformationById(int id);
        void CreateInformation(Information info);

        void UpdateInformation(Information info);

    }
}
