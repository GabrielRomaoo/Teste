using Examples.Charge.Application.Common.Messages;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonPhoneFacade
    {
        Task<BaseResponse> CreatePersonPhone(CreatePersonPhoneRequest request);
        Task<BaseResponse> DeletePersonPhone(DeletePersonPhoneRequest request);
        Task<BaseResponse> UpdatePersonPhone(UpdatePersonPhoneRequest request);
    }
}
