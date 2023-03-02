using System;
using System.Net.NetworkInformation;

namespace Employees {
    interface IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Fullname();
    }
    class Program
    {
        class Leader : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Initial { get; set; }
            public string Comment { get; set; }

            public int NBook { get; set; }


            public Leader()
            {
                Id = 0;
                FirstName= string.Empty;
                LastName = string.Empty;
                Initial= string.Empty;
                Comment= string.Empty;
                NBook= 0;

            }
            public Leader(int id, string firstName, string lastName, string initial, string comment, int Nbook)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Initial = initial;
                Comment = comment;
                NBook = Nbook;
            }
            public string Fullname()
            {
                return FirstName + "" + LastName;
            }
            public string Details()
            {
                return Id + " " + NBook + " " + Initial + " " + Comment; 
            }
            static void Main(string[] args)
            {
                Leader jeff = new Leader(12, "Jeff", "Walberge", "JW", "Love Cats", 5);
                Console.WriteLine(jeff.Fullname());
                Console.WriteLine(jeff.Details());

                Leader Roxanne = new Leader();
                Roxanne.Id = 20;
                Roxanne.FirstName = "Roxy";
                Roxanne.LastName = "Stone";
                Roxanne.Initial = "RS";
                Roxanne.Comment = "Loves Reading";
                Roxanne.NBook = 6;
                Console.WriteLine(Roxanne.Fullname());
                Console.WriteLine(Roxanne.Details());

            }
        }

    }


}