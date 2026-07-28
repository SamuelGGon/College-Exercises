
using System;

namespace Betola
{
    class Betola
    {
       
        public T ConterTo<T>(string value)
        {
            var userType = typeof(T);
            
            

           if (userType == typeof(int))
           {
               
                return (int)T Convert.ToInt32(value);
                
           }

        }

    }

}

