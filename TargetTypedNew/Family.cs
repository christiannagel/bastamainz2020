using System;
using System.Collections.Generic;

namespace TargetTypedNew
{
    public class Family
    {
        private List<Person> members = new();

        public void ShowMembers()
        {
            foreach (var member in members)
            {
                Console.WriteLine(member);
            }
        }
    }
}
