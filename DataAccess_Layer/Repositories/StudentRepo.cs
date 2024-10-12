using DataAccess_Layer.Models;
using DataAccess_Layer.RepositoriesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Repositories
{
    public class StudentRepo : StudentIRepo
    {
        //public StudentRepo()
        public Task<IEnumerable<Student>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Student student)
        {
            throw new NotImplementedException();
        }

        public Task AddNewAsync(Student student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

    }
}
