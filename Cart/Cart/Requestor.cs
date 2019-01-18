using System;

namespace proCart
{
    [Serializable]
    public class Requestor
    {
        private string firstName;
        private string lastName;

        public Requestor(string f, string l)
        {
            this.firstName = f;
            this.lastName = l;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
    }

}
