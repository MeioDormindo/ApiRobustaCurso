using Manager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Infra.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByEmail(String email);
        Task<List<User>> SearchByEmail(String email);
        Task<List<User>> SearchByName(String name);
    }
}
