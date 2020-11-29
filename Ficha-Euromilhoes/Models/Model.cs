using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Euromilhoes.Models
{
    abstract class Model
    {
        public DateTime CreatedAt = DateTime.Today;
        public string Data {
            get { return $"{CreatedAt.Day}/{CreatedAt.Month}/{CreatedAt.Year}"; }
        }

        public Model()
        {}
        
        
    }
}
