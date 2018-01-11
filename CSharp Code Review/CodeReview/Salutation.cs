using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview
{
    /// <summary>
    /// The Salutation class represents something that can say hello or goodbye
    /// </summary>
    public class Salutation
    {
        #region Variables
        // a computer program is a set of instruction for manipulating information
        private string hello, goodbye;
        public string name { get; set; }
        #endregion
     
        #region Constructor
        /// <summary>
        /// Instantiates a Salutation object with appropriate messages
        /// </summary>
        /// <param name="greeting">The message to use when greeting</param>
        /// <param name="farewell">The message to use when saying farewell</param>
        public Salutation(string greeting, string farewell, string person)
        {
            hello = greeting;
            goodbye = farewell;
            name = person;
        }
        public string Greet()
        {
            return hello;
        }
        public string Farewell()
        {
            return goodbye;
        }
        #endregion
    }
}
