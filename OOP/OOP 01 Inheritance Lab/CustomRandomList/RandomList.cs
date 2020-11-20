using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    class RandomList : List<string>
    {
        public string RandomString()
        {
            Random rand = new Random();
            int randomIndex = rand.Next(0, this.Count);
            string randomString = this[randomIndex];
            this.Remove(randomString);
            return randomString;
        }
    }
}
