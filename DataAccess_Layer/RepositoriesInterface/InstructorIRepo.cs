using DataAccess_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.RepositoriesInterface
{
    
    public interface InstructorIRepo 
    {
        Task<Instructor> GetByIdAsync(int id);
        Task<IEnumerable<Instructor>> GetAllAsync();
        Task AddNewAsync(Instructor instructor);
        Task DeleteAsync(int id);
        Task UpdateAsync(Instructor instructor);
    }
}
