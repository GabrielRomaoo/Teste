using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;
using System;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : BaseController
    {
        private IPersonPhoneFacade _facade;

        public ExampleController(IPersonPhoneFacade facade, IMapper mapper)
        {
            _facade = facade;
        }
                
        [HttpPost]
        public async Task<IActionResult> Create([FromBody ]CreatePersonPhoneRequest request)
        {
            try
            {
                var result = await _facade.CreatePersonPhone(request);

                return Response(result);
            }
            catch(Exception e)
            {
                var response = new CreatePersonPhoneResponse { Message = e.Message };
                return Response(response);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeletePersonPhoneRequest request)
        {
            try
            {
                var result = await _facade.DeletePersonPhone(request);

                return Ok(Response(result));
            }
            catch (Exception e)
            {
                var response = new CreatePersonPhoneResponse { Message = e.Message };
                return BadRequest(Response(response));
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdatePersonPhoneRequest request)
        {
            try
            {
                var result = await _facade.UpdatePersonPhone(request);

                return Ok(Response(result));
            }
            catch (Exception e)
            {
                var response = new CreatePersonPhoneResponse { Message = e.Message };
                return BadRequest(Response(response));
            }
        }
    }
}
