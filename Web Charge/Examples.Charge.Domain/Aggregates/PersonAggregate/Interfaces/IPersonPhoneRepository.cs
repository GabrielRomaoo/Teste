using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneRepository
    {
        Task<IEnumerable<PersonAggregate.PersonPhone>> FindAllAsync();

        void Create(PersonPhone personPhone);
        void Delete(PersonPhone personPhone);
        void Update(PersonPhone personPhone);
        
    }
}
