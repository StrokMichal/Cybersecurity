using Cybersecurity.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybersecurity.Application.User
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator(IUserRepository repository)
        {
            RuleFor(c => c.UserName)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(20)
                .Custom((value, context) =>
                {
                    var existingUser = repository.GetByName(value).Result;
                    if (existingUser != null)
                    {
                        context.AddFailure("Użytkownik już istnieje.");
                    }
                });

            RuleFor(c => c.UserEmail)
                .NotEmpty()
                .EmailAddress();
            
                

        }
    }
}
