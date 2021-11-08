using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UKParliament.CodeTest.Services
{
    public interface IPersonService
    {
        /// Change Log:
        /// simonjpearson | 06 Nov, 2021 | Added methods for interface

        Task<List<T>> Index<T>() where T : class;
        Task<T> Details<T>(int id) where T : class;
        Task CreateAsync<T>(T entity) where T : class;
        Task UpdateAsync<T>(T entity) where T : class;
        Task DeleteAsync<T>(T entity) where T : class;

    }
}