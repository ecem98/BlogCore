using EntityLayer.Concrete;
using System;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.CommentUserName).NotEmpty().WithMessage("İsim kısmı boş geçilemez.");
            RuleFor(x => x.CommentTitle).NotEmpty().WithMessage("Başlık boş geçilemez.");
            RuleFor(x => x.CommentContent).NotEmpty().WithMessage("Yoeum boş geçilemez.");
            RuleFor(x => x.CommentUserName).MinimumLength(2).WithMessage("İsim kısmına en az iki karakter girişi yapın.");
            RuleFor(x => x.CommentTitle).MinimumLength(3).WithMessage("Başlık en az üç karakter girişi yapın.");
          
      
     
        }

    }
    
}
