using ExamApi.Application.Features.Commands.Lesson.CreateLesson;
using ExamApi.Application.Features.Commands.Lesson.RemoveLesson;
using ExamApi.Application.Features.Commands.Lesson.UpdateLesson;
using ExamApi.Application.Features.Queries.Lesson.GetAllLesson;
using ExamApi.Application.Features.Queries.Lesson.GetLessonById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ExamApi.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LessonsController(IMediator mediator)
        {

            _mediator = mediator;
        }

        [HttpGet("lessons")]
        public async Task<IActionResult> GetAllLessons([FromQuery] GetAllLessonQueryRequest request)
        {
            GetAllLessonQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("lesson/{Id}")]
        public async Task<IActionResult> GetLessonById([FromRoute] GetLessonByIdQueryRequest request)
        {
            GetLessonByIdQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("createLesson")]
        public async Task<IActionResult> CreateLesson([FromBody] CreateLessonCommandRequest request)
        {

            CreateLessonCommandResponse reponse = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);

        }

        [HttpPut("updateLesson")]
        public async Task<IActionResult> UpdateLesson([FromBody] UpdateLessonCommandRequest request)
        {
            UpdateLessonCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("delete/{Id}")]
        public async Task<IActionResult> DeleteLesson([FromRoute] RemoveLessonCommandRequest request)
        {
            RemoveLessonCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
