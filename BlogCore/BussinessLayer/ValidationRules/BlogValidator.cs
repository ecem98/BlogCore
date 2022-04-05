using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator(){
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Başlık kısmı boş geçilemez.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("İçerik kısmı boş geçilemez.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Görsel kısmı boş geçilemez.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Başlık kısmına en fazla 150 karakter girilebilir.");
            RuleFor(x => x.BlogContent).MaximumLength(150).WithMessage("İçerik kısmına en fazla 150 karakter girilebilir.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Başlık kısmına 4 karakterden fazla değer girilmeli.");
            RuleFor(x => x.BlogContent).MinimumLength(5).WithMessage("İçerik kısmına 4 karakterden fazla değer girilmeli.");
        }

    }
}
