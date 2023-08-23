using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly DataContext _dataContext;

        public VillaRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }



        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedAt = DateTime.Now;
            _dataContext.Villas.Update(entity);
            await _dataContext.SaveChangesAsync();
            return entity;
        }
    }
}
