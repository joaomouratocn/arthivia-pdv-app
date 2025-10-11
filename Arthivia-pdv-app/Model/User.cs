using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthivia_pdv_app.Model
{
    public class User
    {
        public Guid Id { get;  private set; }
        public string Name { get; private set; }
        public string CPF { get; private set; }
        public string Username { get;  private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public Boolean IsActive { get; private set; }

        private User() { }

        public class Builder
        {
            private readonly User _user = new User();
            public Builder WithId(Guid id)
            {
                _user.Id = id;
                return this;
            }
            public Builder WithName(string name)
            {
                _user.Name = name.ToUpper();
                return this;
            }
            public Builder WithCPF(string cpf)
            {
                _user.CPF = cpf;
                return this;
            }
            public Builder WithUsername(string username)
            {
                _user.Username = username.ToUpper();
                return this;
            }
            public Builder WithPassword(string password)
            {
                _user.Password = password;
                return this;
            }
            public Builder WithRole(string role)
            {
                _user.Role = role.ToLower();
                return this;
            }
            public Builder WithCreatedAt(DateTime createdAt)
            {
                _user.CreatedAt = createdAt;
                return this;
            }
            public Builder WithUpdatedAt(DateTime updatedAt)
            {
                _user.UpdatedAt = updatedAt;
                return this;
            }
            public Builder WithIsActive(Boolean isActive)
            {
                _user.IsActive = isActive;
                return this;
            }
            public User Build()
            {
                if (_user.Id == Guid.Empty)
                {
                    _user.Id = Guid.NewGuid();
                }
                if (string.IsNullOrWhiteSpace(_user.Name))
                {
                    throw new InvalidOperationException("Name cannot be null or empty.");
                }
                if (string.IsNullOrWhiteSpace(_user.CPF))
                {
                    throw new InvalidOperationException("CPF cannot be null or empty.");
                }
                if (string.IsNullOrWhiteSpace(_user.Username))
                {
                    throw new InvalidOperationException("Username cannot be null or empty.");
                }
                if (string.IsNullOrWhiteSpace(_user.Password))
                {
                    throw new InvalidOperationException("Password cannot be null or empty.");
                }
                if (string.IsNullOrWhiteSpace(_user.Role))
                {
                    throw new InvalidOperationException("Role cannot be null or empty.");
                }
                if (_user.CreatedAt == DateTime.MinValue)
                {
                    _user.CreatedAt = DateTime.Now;
                }
                if (_user.UpdatedAt == DateTime.MinValue)
                {
                    _user.UpdatedAt = DateTime.Now;
                }
                return _user;
            }
        }
    }
}
