using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameOfThrones.Api.Models;

namespace GameOfThrones.Api.DTOs.Character
{
    public class CharacterListDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string? House { get; set; }
    }
}