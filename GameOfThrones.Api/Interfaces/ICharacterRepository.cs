using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameOfThrones.Api.Models;

namespace GameOfThrones.Api.Interfaces
{
    public interface ICharacterRepository
    {
        Task<List<Character>> GetAllAsync();
    }
}