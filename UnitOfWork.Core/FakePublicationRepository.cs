using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Core
{
    public class FakePublicationRepository : IPublicationRepository
    {
        private List<Publication> DataContext { get; set; }

        public FakePublicationRepository()
        {
            DataContext = new List<Publication>();
            DataContext.Add(new Publication { Id = 1, Title = "1" });
            DataContext.Add(new Publication { Id = 2, Title = "2" });
            DataContext.Add(new Publication { Id = 3, Title = "3" });
            DataContext.Add(new Publication { Id = 4, Title = "4" });
            DataContext.Add(new Publication { Id = 5, Title = "5" });
            DataContext.Add(new Publication { Id = 6, Title = "6" });
        }

        public Publication AddEntity(Publication entity)
        {
            DataContext.Add(entity);
            return entity;
        }

        public void RemoveEntity(Publication entity)
        {
            DataContext.Remove(entity);
        }

        public Publication Find(int id)
        {
            return DataContext.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Publication> FindAll()
        {
            return DataContext.ToList();
        }
    }
}
