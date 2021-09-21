using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDICore.Models
{
    public class DogViewModel
    {
        DogRepo repo;

        public DogViewModel()
        {
            repo = new DogRepo();
        }
    }
}
