using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackathonNew.Model;
using HackathonNew.Interface;

namespace HackathonNew.Service
{

    public class UserServiceFacke : IUserService
    {
        private readonly List<User> _user;
        public UserServiceFacke()
        {
            _user = new List<User>()
            {
                new User() { Id = 1,
                    FirstName = "Test", LastName="TestLast" }

            };
        }

        public async Task<List<User>> GetAll()
        {
            return _user;
        }
        public async Task<User> GetById(int Id)
        {
            return _user.Where(a => a.Id == Id)
            .FirstOrDefault();
        }
        public async Task Insert(User _User)
        {
            return;

        }

        public async Task DeleteById(int Id)
        {
            var result =_user.First(a => a.Id == Id);
            return ;
        }
    }

        
}
