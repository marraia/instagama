using InstaGama.Domain.Core;
using System;

namespace InstaGama.Domain.Entities
{
    public class User
    {
        public User(string email,
                     string password,
                     string name,
                     DateTime birthday,
                     Gender gender,
                     string photo)
        {
            Email = email;
            CriptografyPassword(password);

            Name = name;
            Birthday = birthday;
            Gender = gender;
            Photo = photo;
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public DateTime Birthday { get; private set; }
        public Gender Gender { get; private set; }
        public string Photo { get; private set; }

        public bool IsValid()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(Name) ||
                Birthday.ToShortDateString() == "01/01/0001" ||
                Gender.Id <= 0 ||
                string.IsNullOrEmpty(Photo))
            {
                valid = false;
            }

            return valid;
        }

        private void CriptografyPassword(string password)
        {
            Password = PasswordHasher.Hash(password);
        }

        public bool IsEqualPassword(string password)
        {
            return PasswordHasher.Verify(password, Password);
        }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}
