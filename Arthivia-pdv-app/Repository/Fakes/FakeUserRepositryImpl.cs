using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arthivia_pdv_app.Model;

namespace Arthivia_pdv_app.Repository.Fakes
{
    internal class FakeUserRepositorImpl : UserRepositoryInterface
    {
        private static FakeUserRepositorImpl ? _instance;
        private static readonly object _lock = new object();

        private readonly BindingList<UserModel> _users = new BindingList<UserModel>();

        public static FakeUserRepositorImpl GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new FakeUserRepositorImpl();
                    }
                }
            }
            return _instance;
        }

        private FakeUserRepositorImpl()
        {
            _users.Add(new UserModel.Builder().WithName("João Mourato")
                .WithCPF("123.456.789-00")
                .WithUsername("JOAO")
                .WithPassword("1234")
                .WithRole(util.UserRole.ADMIN)
                .WithCreatedAt(DateTime.Now.AddDays(-10))
                .WithUpdatedAt(DateTime.Now)
                .WithIsActive(util.UserStatus.ATIVO)
                .Build());

            _users.Add(new UserModel.Builder().WithName("Maria Silva").WithCPF("987.654.321-00")
                .WithUsername("OLIVIA")
                .WithPassword("ABCDEFG")
                .WithRole(util.UserRole.USER)
                .WithCreatedAt(DateTime.Now.AddDays(-5))
                .WithUpdatedAt(DateTime.Now)
                .WithIsActive(util.UserStatus.ATIVO)
                .Build());
        }

        public void Add(UserModel user)
        {
            _users.Add(user);
        }

        public void Delete(Guid id)
        {
            var user = GetById(id);
            if (user != null)
                _users.Remove(user);
        }

        public BindingList<UserModel> GetAll()
        {
            return _users;
        }

        public UserModel? getById(Guid Id) 
        {
            var user = _users.FirstOrDefault(u => u.Id == Id);
            return user;
        }

        public UserModel? GetById(Guid id) => _users.FirstOrDefault(u => u.Id == id);

        public void Update(UserModel user)
        {
            var findedUser = getById(user.Id);
            if (findedUser != null)
            {
                var index = _users.IndexOf(findedUser);
                _users[index] = user;
            }
        }
    }
}
