using Manager.Services.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.Services.Interface
{
    public interface IUserService
    {
        Task<UserDTO> Create(UserDTO userDTO);
        Task<UserDTO> Update(UserDTO userDTO);
        Task Remove(long id);
        Task<UserDTO> Get(long id);
        Task<List<UserDTO>> Get();
        Task<List<UserDTO>> SearchByName(String name);
        Task<List<UserDTO>> SearchByEmail(String email);
        Task<UserDTO> GetByEmail(String email);
    }
}
