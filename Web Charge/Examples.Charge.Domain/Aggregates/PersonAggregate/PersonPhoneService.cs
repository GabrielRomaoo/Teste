using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonPhoneService : IPersonPhoneService
    {
        private readonly IPersonPhoneRepository _personPhoneRepository;
        public PersonPhoneService(IPersonPhoneRepository personPhoneRepository)
        {
            _personPhoneRepository = personPhoneRepository;
        }

        public void CreatePersonPhone(PersonPhone personPhone)
        {
            if(String.IsNullOrEmpty(personPhone.PhoneNumber))
            {
                throw new NullReferenceException("Por favor, preencha o número a ser cadastrado!");
            }
            _personPhoneRepository.Create(personPhone);
        }

        public void DeletePersonPhone(PersonPhone personPhone)
        {
            _personPhoneRepository.Delete(personPhone);
        }

        public async Task<List<PersonPhone>> FindAllAsync() => (await _personPhoneRepository.FindAllAsync()).ToList();

        public void UpdatePersonPhone(PersonPhone personPhone)
        {
            _personPhoneRepository.Update(personPhone);
        }
    }
}
