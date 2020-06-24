using System.Collections.Generic;

namespace Starint.Data.EmailLists
{
    public interface IEmailListRepository
    {
        IEnumerable<EmailList> AllEmail { get; }

        EmailList AddEmail(string email);
        EmailList DeleteEmail(string email);
        EmailList GetByEmail(string email);
    }
}