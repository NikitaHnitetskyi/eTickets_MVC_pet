﻿using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IProducerServices
    {
        Task<IEnumerable<Producer>> GetAllAsync();
        Task<Producer> GetByIdAsync(int id);
        Task AddAsync(Producer producer);
        Task<Producer> UpdateAsync(int id, Producer newProducer);
        Task DeleteAsync(int id);
    }
}
