using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDICore.Models
{
    public interface IDog : IAboutable
    {
        
        int DogID { get; }
        string Name { get; set;  }
        int Age { get; set; }

    }

    public interface IAboutable
    {
        string About();
    }

}
