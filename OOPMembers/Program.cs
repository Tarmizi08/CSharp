using System;
using System.Diagnostics;

namespace OOPMembers
{
    class Member
    {
        // field
        private string memberName;
        private string jobTitle;
        private int salary;

        public int age;


        // member-property - expose jobtitle safely -start capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // public member method - can be called by other classes

        public void Introduce(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and My job is {1}. I am {2} years old", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My Salary is {0}", salary);
        }

        // member constructor
        public Member()
        {
            age = 30;
            memberName = "Tarmizi";
            salary = 14000;
            jobTitle = "Takaful advisor";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor
        ~Member()
        {
            // cleanup statement
            Console.WriteLine("Deconstruction of member object");
            Debug.Write("Destruction of member object");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();
            member.Introduce(true);
            Console.ReadKey();
        }
    }
}

