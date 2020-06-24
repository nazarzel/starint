using System.Collections.Generic;

namespace Starint.Data.Colors
{
    public interface IColorRepository
    {
        IEnumerable<Color> AllColors { get; }

        void Create(Color color);
        void Delete(Color color);
        Color GetById(int id);
        void Update(Color color);
    }
}