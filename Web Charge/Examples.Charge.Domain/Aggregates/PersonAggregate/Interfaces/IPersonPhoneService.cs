using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneService
    {
        void CreatePersonPhone(PersonPhone personPhone);
        void DeletePersonPhone(PersonPhone personPhone);
        void UpdatePersonPhone(PersonPhone personPhone);

    }
}
