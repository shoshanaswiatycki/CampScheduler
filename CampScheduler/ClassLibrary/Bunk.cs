using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bunk
    {
        public Bunk() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public int AgeGroupId { get; set; }
        public int HeadCount { get; set; }
    }
}
