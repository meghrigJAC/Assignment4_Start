using System.Collections.Generic;

namespace Assignment4_Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 
            /*
             * 1. Comment all the unit tests in UnitTests.cs
             * 2. Create Smartphone.cs and code all the fields, Properties and methods as per requirements. 
             * 3. Test your SmartPhone class here in Program.cs. 
             * 4. Once satisfied with your class implementation, uncomment all the unit tests in UnitTests.cs
             * 5. See which tests do not pass. Look at the unit tests code and understand why they do pass regarding your implementation. 
             * 6. Go back to the SmartPhone class and fix the code so that the unit tests pass.
             * 7. After all tests pass, get someone to test your code, without looking at your code. 
             * 8. When ready to submit. Do Build => Clean Solution. Then zip the whole project and submit on Moodle. 
             */

            //Add a Try-Catch Block here
            //Add your code here that creates 4 Smartphone objects and places them in a list.
            //Loop over the list and display every object's information.
            //Example: 

            try
            {
                List<Smartphone> phones = new List<Smartphone>();

                Smartphone s = new Smartphone(2023, "iphone 14", 100, 256, 0);
                Smartphone s1 = new Smartphone(2023, "iphone 13", 100, 512, 0);
                Smartphone s2 = new Smartphone(2023, "iphone 13", 100, 256, 0);
                Smartphone s3 = new Smartphone(2023, "iphone 12", 100, 256, 0);
                
                phones.Add(s);
                phones.Add(s1);
                phones.Add(s2);
                phones.Add(s3);
                foreach (Smartphone phone in phones)
                    Console.WriteLine(phone.ToString());

            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
