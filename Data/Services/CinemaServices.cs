﻿using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class CinemaServices : ICinemaServices
    {
        private readonly AppDbContext _context;

        public CinemaServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Cinema cinema)
        {
            await _context.Cinemas.AddAsync(cinema);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Cinemas.FirstOrDefaultAsync(n => n.Id == id);
            _context.Cinemas.Remove(result);
            await _context.SaveChangesAsync();
        }


        public async Task<IEnumerable<Cinema>> GetAllAsync()
        {
            var result = await _context.Cinemas.ToListAsync();
            return result;
        }

        public async Task<Cinema> GetByIdAsync(int id)
        {
            var result = await _context.Cinemas.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Cinema> UpdateAsync(int id, Cinema newCinema)
        {
            _context.Update(newCinema);
            await _context.SaveChangesAsync();
            return newCinema;
        }
    }
}
