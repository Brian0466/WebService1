using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyFirstWebService
{
    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class Service1 : System.Web.Services.WebService
    {

        //Beginning of the Fibonacci Function

        [WebMethod]  //Declaring Web method, making method callable by remote Web Clients

        // The function is called 'Fibonacci' And it returns an array of Double integers.
        // It takes a single integer input from the client which is the length of array 
        // requested, which is assigned the name 'Number'

        public Double[] Fibonacci(int Number)
        {
            Double[] Fib;                   // Create a variable called Fib of type Double Array
            Fib = new Double[Number];       // Declare Fib as an array of Doubles with a length of 'Number',...
                                            //                              ...The value sent to the function  

            Fib[0] = 0;                     // The first 2 values in the sequence need to be declared first before...
            Fib[1] = 1;                     // ...the rest can be calculated. Here, they are 0 and 1

            for (int i = 2; i < Number; i++)// Loop from i = 2 to < 'Number', Start at i=2 as first 2 values already declared
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];       // Calculate array values as sum of previous 2 values
            }


            return Fib;                     // Once for loop finished, return the array 'Fib'
        }
    }
}