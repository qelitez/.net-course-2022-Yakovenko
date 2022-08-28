using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Client : Person
    {
        private string codeClient;
        public string CodeClient { get { return codeClient; } set { codeClient = value; } }
    }
   
}
