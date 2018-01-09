using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview
{
    public class Salutation
    {
        private string hello, goodbye;
        public Salutation(string greeting, string farewell)
        {
            hello = greeting;
            goodbye = farewell;
        }
        public string Greet()
        {
            return hello;
        }
        public string Farewell()
        {
            return goodbye;
        }
    }
}
