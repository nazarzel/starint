using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Data.Communications
{
    public class CommunicationRepository : ICommunicationRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public CommunicationRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Communication> AllCommunications
        {
            get
            {
                return _appDbContext.Communications.ToList();
            }
        }
        public Communication GetById(int id)
        {
            return _appDbContext.Communications.Where(o => o.Id == id).FirstOrDefault();
        }
        public void Update(Communication communication)
        {
            _appDbContext.Communications.Update(communication);
            _appDbContext.SaveChanges();
        }
        public void Create(Communication communication)
        {
            _appDbContext.Communications.Add(communication);
            _appDbContext.SaveChanges();
        }
        public void Delete(Communication communication)
        {
            _appDbContext.Communications.Remove(communication);
            _appDbContext.SaveChanges();
        }
    }
}
