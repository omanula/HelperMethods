using System;

namespace HelperMethods
{
    class MainClass
    {
        // A method is a code block with a name
        // Concept - we can offload certain operation to other
                  // methods to organize and reuse our code. 

        public static void Main(string[] args)
        {
            string myValue = superSecretFormula();
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        // the method MUST be inside class, after Main string
        private static string superSecretFormula()
        // private: can only be called within this class
        // public: can be called from outside the class
        // string: data type for the return of this method
        {
            // some cool stuff here
            return "Hello World";
            // return: command to deliver results back to method 
            // that called it.
        }

    }
}
