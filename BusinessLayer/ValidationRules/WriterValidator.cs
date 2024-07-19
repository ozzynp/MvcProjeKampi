using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("yazar Soyadını Boş Geçemezsiniz");          
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar Hakkında Ksımını Boş Geçemzsiniz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar Mailini Boş Geçemezsiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar Ünvanını Boş Geçemezsiniz");

            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayınız");
            RuleFor(x => x.WriterAbout).Matches(".*a.*").WithMessage("Yazar Hakkında Kısmında mutlaka 'a' harfi geçmelidir");
        }
    }
}
