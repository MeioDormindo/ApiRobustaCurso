using Manager.Core.Exceptions;
using Manager.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Entities
{
    public class User : Base
    {
        //Propriedades
        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }

        //EF
        protected User() { }

        public User(string name, string email, string password)
        {
            this.Name = name;
            Email = email;
            Password = password;
            _errors = new List<string>();
        }

        //Comportamentos
        public void changeName(string name)
        {
            Name = name;
            Validate();
        }

        public void changePassword(string passWord)
        {
            Password = passWord;
            Validate();
        }

        public void changeEmail(string email)
        {
            Email = email;
            Validate();
        }

        public override bool Validate()
        {
            var validator = new UserValidator();
            var validation = validator.Validate(this);

            if (!validation.IsValid) 
            { 
                foreach (var error in validation.Errors)
                    _errors.Add(error.ErrorMessage);

                throw new DomainException("Alguns campos estão invalidos, por favor corrigir!", _errors);
            }
            return true;
        }
    }
}
