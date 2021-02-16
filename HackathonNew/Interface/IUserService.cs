using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HackathonNew.Model;

namespace HackathonNew.Interface

{
    public interface IUserService
    {
        Task<List<User>> GetAll();
        Task<User> GetById(int Id);
        Task Insert(User User);
        Task DeleteById(int Id);
    }
}
