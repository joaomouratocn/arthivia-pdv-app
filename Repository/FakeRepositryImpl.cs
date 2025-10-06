using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arthivia_pdv_app.Model;

namespace Arthivia_pdv_app.Repository
{
    internal class UserRepositorImpl : UserRepositoryInterface
    {
        private readonly List<User> _users = new List<User>();

        public UserRepositorImpl()
        {
            _users.AddRange(new[]
{
            new User
            {
                Id = Guid.NewGuid(),
                Name = "João Mourato",
                CPF = "123.456.789-00",
                Username = "joao",
                Password = "1234",
                Role = "admin",
                CreatedAt = DateTime.Now.AddDays(-10),
                UpdatedAt = DateTime.Now,
                IsActive = true
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Maria Silva",
                CPF = "987.654.321-00",
                Username = "maria",
                Password = "abcd",
                Role = "user",
                CreatedAt = DateTime.Now.AddDays(-5),
                UpdatedAt = DateTime.Now,
                IsActive = true
            }
        });
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

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User? GetById(Guid id) => _users.FirstOrDefault(u => u.Id == id);

        public void Update(User user)
        {
            var existing = GetById(user.Id);
            if (existing is null) return;

            existing.Name = user.Name;
            existing.CPF = user.CPF;
            existing.Username = user.Username;
            existing.Password = user.Password;
            existing.Role = user.Role;
            existing.UpdatedAt = DateTime.Now;
            existing.IsActive = user.IsActive;
        }

        public void Clear() => _users.Clear();

    }
}
