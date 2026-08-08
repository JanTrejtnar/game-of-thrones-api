using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfThrones.Api.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        

        public List<Character> Characters { get; set; } = new();
    }
}