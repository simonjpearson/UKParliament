using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UKParliament.CodeTest.Data;

namespace UKParliament.CodeTest.Services
{

    public class PersonService<PersonManagerContext> : IPersonService where PersonManagerContext : DbContext
    {
        /// Change Log:
        /// simonjpearson | 06 Nov, 2021 | Implementation of methods from interface for CRUD operations

        protected PersonManagerContext _context;
        public PersonService(PersonManagerContext context)
        {
            _context = context;
        }

        async Task<List<T>> IPersonService.Index<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }

        async Task<T> IPersonService.Details<T>(int id) where T : class
        {
            return await _context.Set<T>().FindAsync(id);
        }

        async Task IPersonService.CreateAsync<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
            _ = await _context.SaveChangesAsync();
        }

        async Task IPersonService.UpdateAsync<T>(T entity) where T : class
        {
            _context.Set<T>().Update(entity);
            _ = await _context.SaveChangesAsync();
        }

        async Task IPersonService.DeleteAsync<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
            _ = await _context.SaveChangesAsync();
        }
    }
}