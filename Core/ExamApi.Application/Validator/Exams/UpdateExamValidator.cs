using ExamApi.Application.Features.Commands.Exam.UpdateExam;
using FluentValidation;

namespace ExamApi.Application.Validator.Exams
{
    public class UpdateExamValidator : AbstractValidator<UpdateExamCommandRequest>
    {
        public UpdateExamValidator()
        {
            RuleFor(e => e.Id)
            .NotEmpty()
            .NotNull()
                .WithMessage("Id can't be null or empty!");
            
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
