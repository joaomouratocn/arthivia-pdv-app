using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arthivia_pdv_app.Repository;

namespace Arthivia_pdv_app.Services
{
    internal class UserService
    {
        private UserRepositoryInterface _userRepository;

        public UserService(UserRepositoryInterface userRepository)
        {
            _userRepository = userRepository;
        }


        public int Authenticate(string username, string password)
        {
            var user = _userRepository.GetAll().FirstOrDefault(u => u.Username == username);

            if (user == null)
                return 0;
            else if (user.Password != password)
                return 1;
            else
                return 2; 

        }
    }
}
