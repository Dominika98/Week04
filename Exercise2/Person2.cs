using System;
using System.Runtime.Serialization;

namespace Exercise2
{
    [DataContract]
    class Person2
    {
        [DataMember]
        private string firstName;
        [DataMember]
        private string lastName;
        [DataMember]
        private int ssn;

        public Person2(string firstName, string lastName, int ssn)
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
