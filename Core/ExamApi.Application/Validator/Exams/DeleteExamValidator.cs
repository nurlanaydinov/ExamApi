using ExamApi.Application.Features.Commands.Exam.RemoveExam;
using FluentValidation;

namespace ExamApi.Application.Validator.Exams
{
    public class DeleteExamValidator : AbstractValidator<RemoveExamCommandRequest>
    {
        public DeleteExamValidator()
        {
            RuleFor(e => e.Id)
               .NotEmpty()
               .NotNull()
                  .WithMessage("Id can't be null or empty!");
        }
    }
}
