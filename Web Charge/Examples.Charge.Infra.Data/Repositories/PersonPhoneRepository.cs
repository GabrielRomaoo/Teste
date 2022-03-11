using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : IPersonPhoneRepository
    {
        private readonly ExampleContext _context;

        public PersonPhoneRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Create(PersonPhone personPhone)
        {
            _context.AddAsync(personPhone);
            _context.SaveChanges();
        }

        public void Delete(PersonPhone personPhone)
        {
            _context.Remove(personPhone);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => await Task.Run(() => _context.PersonPhone);

        public void Update(PersonPhone personPhone)
        {
            _context.Entry(personPhone).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
