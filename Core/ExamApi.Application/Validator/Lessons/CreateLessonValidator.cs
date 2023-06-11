using ExamApi.Application.Features.Commands.Lesson.CreateLesson;
using FluentValidation;

namespace ExamApi.Application.Validator.Lessons
{
    public class CreateLessonValidator : AbstractValidator<CreateLessonCommandRequest>
    {
        public CreateLessonValidator()
        {
            RuleFor(e => e.LessonCode)
               .NotEmpty()
               .NotNull()
                   .WithMessage("Lesson code can't be null or empty!")
               .MaximumLength(3)
                  .WithMessage("Lesson code can't be ower 3 charecter");

            RuleFor(e => e.LessonName)
                 .NotEmpty()
                 .NotNull()
                    .WithMessage("Lesson name can't be null or empty!")
                 .MaximumLength(30)
                    .WithMessage("Lesson name can't be ower 30 charecter");

            RuleFor(e => e.Class)
                .Must(s => s > 0 && s.ToString().Length <= 2)
                   .WithMessage("Class can't be negative and length must be less than or equal to 2!");

            RuleFor(e => e.TeacherName)
                .NotEmpty()
                .NotNull()
                   .WithMessage("Teacher name can't be null or empty!")
                .MaximumLength(20)
                   .WithMessage("Teacher name can't be ower 20 charecter");

            RuleFor(e => e.TeacherSurname)
               .NotEmpty()
               .NotNull()
                  .WithMessage("Teacher surname can't be null or empty!")
               .MaximumLength(20)
                  .WithMessage("Teacher surname can't be ower 20 charecter");
        }
    }
}
