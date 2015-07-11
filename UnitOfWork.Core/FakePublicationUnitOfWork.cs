using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Core
{
    public class FakePublicationUnitOfWork : IUnitOfWork<IRepository<Publication>>
    {
        public FakePublicationUnitOfWork()
        {
            Repositories = new List<IRepository<Publication>>();
            Repositories.Add(new FakePublicationRepository());
        }

        private List<IRepository<Publication>> Repositories { get; set; }

        public IRepository<Publication> GetRepository<R>()
        {
            return Repositories.FirstOrDefault(x => ((R)x) != null);
        }
    }    
}
