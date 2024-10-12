using DataAccess_Layer.Models;
using DataAccess_Layer.RepositoriesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Repositories
{
    public class InstructorRepo : InstructorIRepo
    {
        public Task AddNewAsync(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Instructor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Instructor> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Instructor instructor)
        {
            throw new NotImplementedException();
        }
    }
}
