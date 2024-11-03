using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.ViewModels;

namespace Vallet.Application.Validators
{
    public class CreateUserValidator : AbstractValidator<UserCreateModel>
    {
        public CreateUserValidator()
        {
            RuleFor(u => u.FullName)
                .NotNull()
                .NotEmpty()
                    .WithMessage("Lütfen Ad-Soyad bilgisini giriniz.")
                .MaximumLength(24)
                .MinimumLength(4)
                    .WithMessage("İsim bilgisi 4-24 karakter uzunluğunda olmalıdır.");
            RuleFor(u => u.Email)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen EPosta bilgisini giriniz.");
            RuleFor(u => u.PhoneNumber)
                 .NotNull()
                .NotEmpty()
                    .WithMessage("Lütfen Telefon bilgisini giriniz.")
                .MinimumLength(10)
                .MaximumLength(11)
                    .WithMessage("Telefon 10-11 karakter olarak giriniz.");
            RuleFor(u => u.Role)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen Role bilgisini giriniz.");








        }
    }
}
