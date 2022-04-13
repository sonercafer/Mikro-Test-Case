using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mikro.API.Models
{
    public class ApiResponse<T>
    { 
        public List<T> data;
    }
}
