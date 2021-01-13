using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            String input = "";
            List<Post> allPosts = new List<Post>();
            do
            {
                Console.WriteLine("===Nhap vao so bat ky de thuc hien chuc nang sau===");
                Console.WriteLine("1) chuc nang 1");
                Console.WriteLine("2) chuc nang 2");
                Console.WriteLine("3) chuc nang 3");
                Console.WriteLine("4) chuc nang 4");
                Console.WriteLine("5) chuc nang 5");
                Console.WriteLine("6) Thoat");
                input = Console.ReadLine();
                if (!"6".Equals(input))
                    ProcessInput(input, allPosts);
            }
            while (!"6".Equals(input));
            Console.WriteLine("Exit the program");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void ProcessInput(String input, List<Post> allPosts)
        {
            if ("1".Equals(input))
            {
                Chucnang1(allPosts);
            }
            else if ("2".Equals(input))
            {
                Chucnang2(allPosts);
            }
            else if ("3".Equals(input))
            {
                // chucnang3(allPosts);
            }
            else if ("4".Equals(input))
            {
                // chucnang4(allPosts);
            }
            else if ("5".Equals(input))
            {
                Chucnang5(allPosts);
            }
            else
            {
                Console.WriteLine("Yeu cau nhap lai (1->6)");
            }
        }

        private static void Chucnang1(List<Post> allPosts)
        {
            Console.Write("Input: ");
            String departmant = Console.ReadLine();
            int maxID = 0;
            foreach (var p in allPosts)
            {
                if (maxID <= p.ID) maxID++;
            }
            Post post = new Post()
            {
                ID = maxID,
                Departmant = departmant,
            };


            if ("CPP".Equals(departmant))
            {
                Console.WriteLine("Name of department (CPP/JAVA):" + departmant);
                allPosts.Add(post);
                foreach (var p in allPosts)
                {
                    Console.WriteLine("ID:" + p.ID);
                    Console.WriteLine("Department:" + p.Departmant);
                }

            }
            else if ("JAVA".Equals(departmant))
            {
                Console.WriteLine("Name of department (CPP/JAVA):" + departmant);
                allPosts.Add(post);
                foreach (var p in allPosts)
                {
                    Console.WriteLine("ID:" + p.ID);
                    Console.WriteLine("Department:" + p.Departmant);
                }
            }

            else
            {
                Console.WriteLine("Invalid");
            }
        }
        private static void Chucnang2(List<Post> allPosts)
        {
            if (allPosts.Count() == 0)
            {
                Console.WriteLine("Nhap lai chuc nang 1:");
            }
            else
            {
                Console.Write("Name: ");
                String Name = Console.ReadLine();
                Console.Write("Age: ");
                String Age = Console.ReadLine();
                int numAge = Int32.Parse(Age);
                if (numAge < 0)
                {
                    Console.WriteLine("Ban phai nhap tuoi duong:");
                }
                else
                {
                    int maxID = 0;
                    foreach (var p in allPosts)
                    {
                        if (maxID <= p.ID) maxID++;
                    }
                    Post post = new Post()
                    {
                        ID = maxID,
                        Name = Name,
                        Age = Age
                    };
                    allPosts.Add(post);

                }

            }

        }
        private static void Chucnang5(List<Post> allPosts)
        {
            if (allPosts.Count() == 0)
            {
                Console.WriteLine("Nhap  lai chuc nang 1");
            }
            else
            {
                Console.WriteLine("Thong tin");
                Console.Write("ID: ");
                String Id = Console.ReadLine();
                foreach (var p in allPosts)
                {
                    Console.WriteLine("ID" + p.ID);
                    Console.WriteLine("Departmant" + p.Departmant);
                }
            }
            
            
        }
    }
    
    class Post
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set
            {
                this._id = value;
            }
        }      
        private String _departmant;
        public String Departmant
        {
            get { return _departmant; }
            set
            {
                this._departmant = value;
            }
        }
        private String _name;
        public String Name
        {
            get { return _name; }
            set
            {
                this._name = value;
            }
        }
        private String _age;
        public String Age
        {
            get { return _age; }
            set
            {
                this._age = value;
            }
        }
    }
}
