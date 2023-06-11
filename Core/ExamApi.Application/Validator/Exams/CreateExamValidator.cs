using ExamApi.Application.Features.Commands.Exam.CreateExam;
using FluentValidation;

namespace ExamApi.Application.Validator.Exams
{
    public class CreateExamValidator : AbstractValidator<CreateExamCommandRequest>
    {
        public CreateExamValidator()
        {
            RuleFor(e => e.LessonCode)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lesson code can't be null or empty!")
                .MaximumLength(3)
                   .WithMessage("Lesson code can't be ower 3 charecter");

            RuleFor(e => e.StudentNumber)
                .Must(s => s > 0 && s.ToString().Length <= 5)
                    .WithMessage("Student number can't be negative and length must be less than or equal to 5!");

            RuleFor(e => e.Rating)
                .Must(s => s >= 0 && s.ToString().Length <= 1)
                   .WithMessage("Student number can't be negative and length must be less than or equal to 1!");
        }
    }
}
