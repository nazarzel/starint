using System.Collections.Generic;

namespace Starint.Data.Communications
{
    public interface ICommunicationRepository
    {
        IEnumerable<Communication> AllCommunications { get; }

        void Create(Communication communication);
        void Delete(Communication communication);
        Communication GetById(int id);
        void Update(Communication communication);
    }
}