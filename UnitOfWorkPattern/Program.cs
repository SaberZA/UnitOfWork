using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Core;

namespace UnitOfWorkPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnitOfWork<IRepository<Publication>> unitOfWork = new FakePublicationUnitOfWork();
            IRepository<Publication> publicationRepository = unitOfWork.GetRepository<IPublicationRepository>();
            var publications = publicationRepository.FindAll();
            foreach (var publication in publications)
            {
                Console.WriteLine(publication.Title);
            }
            Console.ReadKey();
        }
    }
}
