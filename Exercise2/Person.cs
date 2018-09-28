using System;

namespace Exercise2
{
    [Serializable]
    class Person
    {

        private string firstName;
        private string lastName;
        private int ssn;

        public Person(string firstName, string lastName, int ssn)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
    }
}
