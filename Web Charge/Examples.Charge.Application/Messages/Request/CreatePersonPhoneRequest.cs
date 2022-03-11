using Examples.Charge.Application.Common.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Charge.Application.Messages.Request
{
    public class CreatePersonPhoneRequest : BaseResponse
    {

        public int BussinessEntityID { get; set; }

        public int PhoneTypeNumberID { get; set; }

        public string PhoneNumber { get; set; }

    }
}
