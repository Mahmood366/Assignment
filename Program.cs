namespace Assinment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    namespace StudentDetails
    {
        class StudentDetails
        {
            public string dda;
            private int ID;
            private string StudentAddress;

            public string getAddress()
            {
                return StudentAddress;
            }
            public void setAddress(string SAddreess)
            {
                StudentAddress = SAddreess;
                Console.WriteLine("Address: " + StudentAddress);
            }

            public void getStudentName(string name)
            {
                dda = name;
                Console.WriteLine("Name: " + name);
            }
            public void getStudentId(int id)
            {
                ID = id;
                Console.WriteLine("ID: " + id);
            }
            public void store()
            {
                Dictionary<int, string> dc = new Dictionary<int, string>();
                dc.Add(1, dda);
                dc.Add(3, StudentAddress);
                dc.Add(2, ID.ToString());

                foreach (KeyValuePair<int, string> i in dc)
                {
                    Console.WriteLine(i.Value);
                }
            }

            private static void Main(string[] args)
            {
                StudentDetails std = new StudentDetails();
                std.getStudentName("Sue");
                std.getStudentId(456);
                std.setAddress("Mbale");

                Console.WriteLine("\nDetails stored in the Dictioary!\n");
                std.store();
            }
        }

    }

}
