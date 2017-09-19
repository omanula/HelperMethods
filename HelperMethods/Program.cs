using System;

namespace HelperMethods
{
    class MainClass
    {
        // A method is a code block with a name
        // Concept - we can offload certain operation to other
                  // methods to organize and reuse our code. 


        // void Main: it doesn't need to return anything
        public static void Main(string[] args)
        {
			// pass the string "world" into superSecretFormula "name"
			// string myValue = superSecretFormula("world");
            string myValue = superSecretFormula("sunshine");
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

        // accept an input perameter type "name"
        // the data type of the return value is found in the name
        private static string superSecretFormula(string name)
        {
            return String.Format("Hello, {0}!", name);
        }

        // Two methods were made with the same name, and both can be used
        // delete "sunshine" perameter, you use the first
        // add in "sunshine" (or other), you use the second

        // Multiple methods can be made with the same name accepting different
                            // data types or different number of perameters



        // void: this method does not return any values
    }
}
