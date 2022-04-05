using EntityLayer.Concrete;
using System.Text.RegularExpressions;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad ve Soyad kısmı boş geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail kısmı boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre kısmı boş geçilemez.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Ad ve Soyad kısmına en az iki karakter girişi yapın.");
            RuleFor(x => x.WriterPassword).MinimumLength(3).WithMessage("Şifre kısmına en az üç karakter girişi yapın.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Ad ve Soyad kısmına en fazla elli karakter girilebilir.");
            RuleFor(x => x.WriterPassword).Equal(x => x.WriterPasswordConfirmation).WithMessage("Şifreler eşleşmiyor.");
            RuleFor(x => x.WriterPassword).Must(BeAValidLowerCase).WithMessage("Şifre en az bir adet küçük harf içermeli.");
            RuleFor(x => x.WriterPassword).Must(BeAValidUpperrCase).WithMessage("Şifre en az bir adet büyük harf içermeli.");
            RuleFor(x => x.WriterPassword).Must(BeAValidNumber).WithMessage("Şifre en az bir adet sayı içermeli.");
        }

        private bool BeAValidLowerCase(string gelen)
        {
            
            Match match = Regex.Match(gelen,@"[a-z]");
            if (match.Success) { return true; }
            else { return false; }
        }

        private bool BeAValidUpperrCase(string gelen)
        {

            Match match = Regex.Match(gelen, @"[A-Z]", RegexOptions.ECMAScript);
            if (match.Success) { return true; }
            else { return false; }
        }

        private bool BeAValidNumber(string gelen)
        {

            Match match = Regex.Match(gelen, @"[0-9]", RegexOptions.ECMAScript);
            if (match.Success) { return true; }
            else { return false; }
        }

    }
}
