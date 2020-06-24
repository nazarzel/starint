using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Data.Colors
{
    public class ColorRepository : IColorRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public ColorRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Color> AllColors
        {
            get
            {
                return _appDbContext.Colors.ToList();
            }
        }
        public Color GetById(int id)
        {
            return _appDbContext.Colors.Where(o => o.Id == id).FirstOrDefault();
        }
        public void Update(Color color)
        {
            _appDbContext.Colors.Update(color);
            _appDbContext.SaveChanges();
        }
        public void Create(Color color)
        {
            _appDbContext.Colors.Add(color);
            _appDbContext.SaveChanges();
        }
        public void Delete(Color color)
        {
            _appDbContext.Colors.Remove(color);
            _appDbContext.SaveChanges();
        }
    }
}
