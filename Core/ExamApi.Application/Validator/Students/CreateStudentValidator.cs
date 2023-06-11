using ExamApi.Application.Features.Commands.Student.CreateStudent;
using FluentValidation;

namespace ExamApi.Application.Validator.Students
{
    public class CreateStudentValidator : AbstractValidator<CreateStudentCommandRequest>
    {
        public CreateStudentValidator()
        {
            RuleFor(e => e.StudentNumber)
                .Must(s => s >= 0 && s.ToString().Length <= 5)
                    .WithMessage("Student number be negative and length must be less than or equal to 5!");   

            RuleFor(e => e.Class)
                .Must(s => s > 0 && s.ToString().Length <= 2)
                    .WithMessage("Class can't be negative and length must be less than or equal to 2!");

            RuleFor(e => e.StudentName)
                .NotEmpty()
                .NotNull()
                   .WithMessage("Student name can't be null or empty!")
                .MaximumLength(30)
                   .WithMessage("Student name can't be ower 30 charecter");

            RuleFor(e => e.StudentSurname)
               .NotEmpty()
               .NotNull()
                  .WithMessage("Student surname can't be null or empty!")
               .MaximumLength(30)
                  .WithMessage("Student surname can't be ower 30 charecter");
        }
    }
}
