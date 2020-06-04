using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWAPI.Models
{

    

        public class PersonList
        {
            public int count { get; set; }
            public string next { get; set; }
            public object previous { get; set; }
            public Person[] results { get; set; }
        }


    
}
