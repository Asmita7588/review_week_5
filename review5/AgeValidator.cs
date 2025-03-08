using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review5
{
    //Create a custom exception InvalidAgeException that is thrown when a user enters an age less than 18.

    
        public class AgeValidator
        {
            public static void ValidateAgeOfUser(int age)
            {
            try
             {
                if (age < 18)
                {
                    throw new InvalidAgeException("Invalid age Eexception");
                    
                }
            }catch(InvalidAgeException ex)
            {
                Console.WriteLine("Error :" +ex);
            }   

            }
        }

    }

