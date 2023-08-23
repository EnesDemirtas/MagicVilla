using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly DataContext _dataContext;

        public VillaNumberRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }



        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _dataContext.VillaNumbers.Update(entity);
            await _dataContext.SaveChangesAsync();
            return entity;
        }
    }
}
