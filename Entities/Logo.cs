using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoGo.Entities
{
    public class Logo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public string PictureUrl { get; set; }
        public string Characteristics { get; set; }
        public bool Availability { get; set; }
    }
}