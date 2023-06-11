using ExamApi.Application.Features.Commands.Student.RemoveStudent;
using FluentValidation;

namespace ExamApi.Application.Validator.Students
{
    public class RemoveStudentValidator : AbstractValidator<RemoveStudentCommandRequest>
    {
        public RemoveStudentValidator()
        {
            RuleFor(e => e.Id)
               .NotEmpty()
               .NotNull()
                  .WithMessage("Id can't be null or empty!");
        }
    }
}
