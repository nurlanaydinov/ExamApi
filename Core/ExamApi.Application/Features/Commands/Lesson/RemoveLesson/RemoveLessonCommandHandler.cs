using ExamApi.Application.Repositories;
using MediatR;

namespace ExamApi.Application.Features.Commands.Lesson.RemoveLesson
{
    public class RemoveLessonCommandHandler : IRequestHandler<RemoveLessonCommandRequest, RemoveLessonCommandResponse>
    {
        private readonly ILessonWriteRepository _lessonWriteRepository;

        public RemoveLessonCommandHandler(ILessonWriteRepository lessonWriteRepository)
        {
            _lessonWriteRepository = lessonWriteRepository;
        }

        public async Task<RemoveLessonCommandResponse> Handle(RemoveLessonCommandRequest request, CancellationToken cancellationToken)
        {
            await _lessonWriteRepository.RemoveAsync(request.Id);
            await _lessonWriteRepository.SaveAsync();
            return new();
        }
    }
}
