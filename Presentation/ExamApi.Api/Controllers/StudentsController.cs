using ExamApi.Application.Features.Commands.Student.CreateStudent;
using ExamApi.Application.Features.Commands.Student.RemoveStudent;
using ExamApi.Application.Features.Commands.Student.UpdateStudent;
using ExamApi.Application.Features.Queries.Student.GetAllStudent;
using ExamApi.Application.Features.Queries.Student.GetStudentById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ExamApi.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentsController(IMediator mediator)
        {

            _mediator = mediator;
        }

        [HttpGet("students")]
        public async Task<IActionResult> GetAllStudents([FromQuery] GetAllStudentQueryRequest request)
        {
            GetAllStudentQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("student/{Id}")]
        public async Task<IActionResult> GetStudentById([FromRoute] GetStudentByIdQueryRequest request)
        {
            GetStudentByIdQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("createStudent")]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentCommandRequest request)
        {

            CreateStudentCommandResponse reponse = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);

        }

        [HttpPut("updateStudent")]
        public async Task<IActionResult> UpdateStudent([FromBody] UpdateStudentCommandRequest request)
        {
            UpdateStudentCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("delete/{Id}")]
        public async Task<IActionResult> DeleteStudent([FromRoute] RemoveStudentCommandRequest request)
        {
            RemoveStudentCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
