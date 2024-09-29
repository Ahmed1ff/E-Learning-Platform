using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning_Platform
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public string GetContent() => Content;
    }

}
