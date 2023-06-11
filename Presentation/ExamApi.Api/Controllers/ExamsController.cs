using ExamApi.Application.Features.Commands.Exam.CreateExam;
using ExamApi.Application.Features.Commands.Exam.RemoveExam;
using ExamApi.Application.Features.Commands.Exam.UpdateExam;
using ExamApi.Application.Features.Queries.Exam.GetAllExam;
using ExamApi.Application.Features.Queries.Exam.GetExamById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ExamApi.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ExamsController(IMediator mediator)
        {

            _mediator = mediator;
        }

        [HttpGet("exams")]
        public async Task<IActionResult> GetAllExams([FromQuery] GetAllExamQueryRequest request)
        {
            GetAllExamQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("exam/{Id}")]
        public async Task<IActionResult> GetExamById([FromRoute] GetExamByIdQueryRequest request)
        {
            GetExamByIdQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("createExam")]
        public async Task<IActionResult> CreateExam([FromBody] CreateExamCommandRequest request)
        { 
            CreateExamCommandResponse reponse = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);

        }

        [HttpPut("updateExam")]
        public async Task<IActionResult> UpdateExam([FromBody] UpdateExamCommandRequest request)
        {
            UpdateExamCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("delete/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveExamCommandRequest request)
        {
            RemoveExamCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
