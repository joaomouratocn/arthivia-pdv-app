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

        private readonly BindingList<User> _users = new BindingList<User>();

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
            _users.Add(new User.Builder().WithName("João Mourato")
                .WithCPF("123.456.789-00")
                .WithUsername("JOAO")
                .WithPassword("1234")
                .WithRole("admin")
                .WithCreatedAt(DateTime.Now.AddDays(-10))
                .WithUpdatedAt(DateTime.Now)
                .WithIsActive(true)
                .Build());

            _users.Add(new User.Builder().WithName("Maria Silva").WithCPF("987.654.321-00")
                .WithUsername("MARIA")
                .WithPassword("ABCDEFG")
                .WithRole("user")
                .WithCreatedAt(DateTime.Now.AddDays(-5))
                .WithUpdatedAt(DateTime.Now)
                .WithIsActive(true)
                .Build());
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Delete(Guid id)
        {
            var user = GetById(id);
            if (user != null)
                _users.Remove(user);
        }

        public BindingList<User> GetAll()
        {
            return _users;
        }

        public User? getById(Guid Id) 
        {
            var user = _users.FirstOrDefault(u => u.Id == Id);
            return user;
        }

        public User? GetById(Guid id) => _users.FirstOrDefault(u => u.Id == id);

        public void Update(User user)
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
