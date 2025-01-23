using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_22._101_Bakhturov_authorization.Models;

namespace PR_22._101_Bakhturov_authorization
{
    internal class Helper
    {
        public static KREntities GetContext()

        { 

            return new KREntities(); 
        
        }
    }
}
