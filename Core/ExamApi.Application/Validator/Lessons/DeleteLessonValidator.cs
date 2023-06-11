using ExamApi.Application.Features.Commands.Lesson.RemoveLesson;
using FluentValidation;

namespace ExamApi.Application.Validator.Lessons
{
    public class DeleteLessonValidator : AbstractValidator<RemoveLessonCommandRequest>
    {
        public DeleteLessonValidator()
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .NotNull()
                   .WithMessage("Id can't be null or empty!");
        }
    }
}
