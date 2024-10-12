using DataAccess_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.RepositoriesInterface
{
    public interface StudentIRepo
    {
        Task<Student> GetByIdAsync(int id);
        Task<IEnumerable<Student>> GetAllAsync();
        Task AddNewAsync(Student student);
        Task DeleteAsync(int id);
        Task UpdateAsync(Student student);
    }
}
