namespace OO_Concepts_C_Sharp {
    class Person {
        public string Name { get; set; }
        public int Age { get; set; }

        public void printDetails() {
            System.Console.WriteLine("The person's name is " + Name + ".");
            System.Console.WriteLine("The person's age is " + Age + ".");
        }
    }
}