using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAppAngular.Models;

namespace TestAppAngular.DataRepository
{
    public class MockInformationRepo : IInformationRepo
    {
        public void CreateInformation(Information info)
        {
          
        }

        public IEnumerable<Information> FetchAllInformations()
        {
            return new List<Information>()
            {
                new Information(1, "HeadLineMockAll1", "This is bread text mockup 1", "This is Footer 1"),
                new Information(2, "HeadLineMockAll2", "This is bread text mockup 2", "This is Footer 2"),
                new Information(3, "HeadLineMockAll3", "This is bread text mockup 3", "This is Footer 3")
        };
        }

        public Information GetInformationById(int id)
        {
            return new Information(id, "HeadLineMock", "This is a bread text mockup", "This is a Footer");
        }

        public bool SaveChanges()
        {
            return true;
        }

        public void UpdateInformation(Information info)
        {
            
        }
    }
}
