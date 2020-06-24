using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Data.EmailLists
{
    public class EmailListRepository : IEmailListRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public EmailListRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<EmailList> AllEmail
        {
            get
            {
                return _appDbContext.EmailLists.ToList();
            }
        }
        public EmailList GetByEmail(string email)
        {
            return _appDbContext.EmailLists.FirstOrDefault(p => p.Email == email);
        }
        public EmailList AddEmail(string email)
        {
            email.ToUpper();
            EmailList newEmail = new EmailList { Email = email };
            if (_appDbContext.EmailLists.FirstOrDefault(p => p.Email == email) == null)
            {
                _appDbContext.EmailLists.Add(newEmail);
                _appDbContext.SaveChanges();
            }
            return newEmail;
        }
        public EmailList DeleteEmail(string email)
        {
            email.ToUpper();
            EmailList newEmail = _appDbContext.EmailLists.FirstOrDefault(p => p.Email == email);
            if (_appDbContext.EmailLists.FirstOrDefault(p => p.Email == email) != null)
            {
                _appDbContext.EmailLists.Remove(newEmail);
                _appDbContext.SaveChanges();
            }
            return newEmail;
        }
    }
}
