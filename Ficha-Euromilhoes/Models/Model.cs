using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Euromilhoes.Models
{
    abstract class Model
    {
        public DateTime CreatedAt { get; set; }
        public string Data {
            get { return $"{CreatedAt.Day}/{CreatedAt.Month}/{CreatedAt.Year}"; }
        }

        public Model()
        {
            CreatedAt = DateTime.Today;
        }
        
        
    }
}
