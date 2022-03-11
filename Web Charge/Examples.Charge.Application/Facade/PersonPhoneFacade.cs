using AutoMapper;
using Examples.Charge.Application.Common.Messages;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PersonPhoneFacade : IPersonPhoneFacade
    {
        private readonly IPersonPhoneService _personPhoneService;
        private readonly IMapper _mapper;
        public PersonPhoneFacade(IPersonPhoneService personPhoneService)
        {
            _personPhoneService = personPhoneService;
        }
        public async Task<BaseResponse> CreatePersonPhone(CreatePersonPhoneRequest request)
        {
            try
            {
                var entity = _mapper.Map<PersonPhone>(request);

                _personPhoneService.CreatePersonPhone(entity);

                return new CreatePersonPhoneResponse { Message = "Telefone Cadastrado com sucesso!" };

            }
            catch(Exception e)
            {
                return new CreatePersonPhoneResponse { Success = false, Message = e.Message };
            }
        }

        public async Task<BaseResponse> DeletePersonPhone(DeletePersonPhoneRequest request)
        {
            try
            {
                var entity = _mapper.Map<PersonPhone>(request);

                _personPhoneService.CreatePersonPhone(entity);

                return new DeletePersonPhoneResponse { Message = "Telefone Cadastrado com sucesso!" };

            }
            catch (Exception e)
            {
                return new DeletePersonPhoneResponse { Success = false, Message = e.Message };
            }
        }

        public async Task<BaseResponse> UpdatePersonPhone(UpdatePersonPhoneRequest request)
        {
            try
            {
                var entity = _mapper.Map<PersonPhone>(request);

                _personPhoneService.CreatePersonPhone(entity);

                return new DeletePersonPhoneResponse { Message = "Telefone Cadastrado com sucesso!" };

            }
            catch (Exception e)
            {
                return new DeletePersonPhoneResponse { Success = false, Message = e.Message };
            }
        }
    }
}
