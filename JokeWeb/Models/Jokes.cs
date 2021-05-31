using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokeWeb.Models
{
    public class Jokes
    {
        public int ID { get; set; }
        public  string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        public Jokes()
        {

        }
    }
   
}
