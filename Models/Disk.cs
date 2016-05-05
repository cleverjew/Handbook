using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook.Models
{
    public class Disk
    {
        public string name;
        public List<Material> ld;
        
        public Disk(string s)
        {
            name = s;
            ld = new List<Material>();
        }
    }
}
