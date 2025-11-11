using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvn
{
    internal class Person
    {
        private String name;
        private int age;
        private String address;

        public Person() {}
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public String Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public String Address { get => address; set => address = value; }

        public override string ToString()
        {
            return $"Ho ten: {name}, tuoi: {age}, dia chi: {address}";
        }
    }
}
