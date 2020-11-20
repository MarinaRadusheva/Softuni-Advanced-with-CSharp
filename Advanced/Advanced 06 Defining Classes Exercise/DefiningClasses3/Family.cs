using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;
        public Family()
        {
            this.Members = new List<Person>();
        }
        public List<Person> Members 
        { 
            get
            { return members; }
            set
            { members = value; }
        }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }
        public Person GetOldestMember()
        {
            int maxAge = -1;
            Person oldest = new Person();
            foreach (var member in this.Members)
            {
                if (member.Age>maxAge)
                {
                    maxAge = member.Age;
                    oldest = member;
                }
            }
            return oldest;
        }
    }
}
