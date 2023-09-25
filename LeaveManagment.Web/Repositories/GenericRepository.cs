using LeaveManagment.Web.Contracts;
using LeaveManagment.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagment.Web.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;
        public GenericRepository(ApplicationDbContext context)
        {
            
            this.context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task AddRangeAsync(List<T> entities)
        {
            await context.AddRangeAsync(entities);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);                    
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
            
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id); // go vrakja  id/korisnikot dali postoi
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();  
        }

        public async Task<T> GetAsync(int? id)
        {
            if(id == null)
            {
                return null;
            }
            return await context.Set<T>().FindAsync(id);        // Ne znaeme dali e LeaveType ili LeaveAllocations
                                                                // ako e LeaveAllocation ke se izbrise sekogas LeaveType so matching id 
                                                                // matchind DBSet e za voa vo ApplicationDbContext dali LeaveType dali LeaveAllocation so vide ke dojde

        }

        public async Task UpdateAsync(T entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
