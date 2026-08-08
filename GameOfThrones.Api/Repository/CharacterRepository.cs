using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameOfThrones.Api.Data;
using GameOfThrones.Api.Interfaces;
using GameOfThrones.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GameOfThrones.Api.Repository
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly GameOfThronesDbContext _context;
        public CharacterRepository(GameOfThronesDbContext context)
        {
            _context = context;
        }
        public async Task<List<Character>> GetAllAsync()
        {
            return await _context.Characters.ToListAsync();
        }
    }
}