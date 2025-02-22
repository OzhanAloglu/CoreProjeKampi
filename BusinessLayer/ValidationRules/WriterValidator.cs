﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.WriterPassword).MinimumLength(4).WithMessage("En az 4 karakter gir");
            RuleFor(x => x.WriterPassword).Matches("[A-Z]").WithMessage("En az bir büyük harf olmalı");
            RuleFor(x => x.WriterPassword).Matches("[a-z]").WithMessage("En az bir küçük harf olmalı");
            RuleFor(x => x.WriterPassword).Matches("[0-9]").WithMessage("En az bir rakam içermeli");


        }
    }
}
