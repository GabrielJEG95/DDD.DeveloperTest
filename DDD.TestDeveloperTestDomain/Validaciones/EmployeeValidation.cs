using DDD.TestDeveloperTestDomain.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TestDeveloperTestDomain.Validaciones
{
    public abstract class EmployeeValidation<T> : AbstractValidator<T> where T : EmployeeCommands
    {
        protected void validateName()
        {
            RuleFor(c => c.EmployeeName)
                .NotEmpty().WithMessage("Favor ingresar el nombre del empleado")
                .Length(2, 150).WithMessage("El nombre debe tener entre 2 y 150 caracteres");
        }
        protected void validateSurname()
        {
            RuleFor(c => c.EmployeeSurname)
                .NotEmpty().WithMessage("Favor ingresar el apellido del empleado")
                .Length(2, 150).WithMessage("El apellido debe tener entre 2 y 150 caracteres");
        }
        protected void ValidateBithDay()
        {
            _ = RuleFor(c => c.Birthday)
                .NotEmpty()
                .Must(EdadMinima)
                .WithMessage("El empleado debe ser mayor de edad");
        }

        protected static bool EdadMinima(DateTime bithday)
        {
            return bithday <= DateTime.Now.AddYears(-18);
        }
    }
}
