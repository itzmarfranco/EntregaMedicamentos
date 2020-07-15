using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicamentos
{
    class user
    {
        public string id
        { get; set; }
        
        public string fullName
        { get; set; }

        public string username
        { get; set; }

        public user() {
            this.id = "-1";
            this.fullName = "";
            this.username = "";
        }

        
    }
}
