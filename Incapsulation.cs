using System;

namespace Program
{
    class Person
    {
        private string Name; // Private field

        public void setName(string name)
        {
            // Trim the input to handle whitespace
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name is required");
            }
            else
            {
                this.Name = name.Trim(); // Store trimmed name
            }
        }

        public string getName()
        {
            return this.Name; // Return the stored name
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            Person p = new Person();
            p.setName(" "); // This will trigger the "Name is required" message
            Console.WriteLine("Name: " + p.getName()); // Will output an empty line because setName failed
        }
    }
}
