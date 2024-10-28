using System;
using testplatformu3;


    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1. Admin Girişi");
            Console.WriteLine("2. Öğrenci Girişi");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
              
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Start(); 
            }
            else if (choice == "2")
            {
              
               StudentPanel studentPanel = new StudentPanel();
               studentPanel.Start(); 
            }
            else
            {
                Console.WriteLine(" Lütfen 1 veya 2 girin.");
            }
            AdminController adminController = new AdminController();
            CategoryController categoryController = new CategoryController();
            StudentController studentController = new StudentController();
            QuestionController questionController = new QuestionController();

            // Admin əlavə etmə
            adminController.AddAdmin("Esma", "esma123");

            // Admin girişi
            Console.WriteLine("Enter your name and password");
            Console.Write("Name: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (adminController.Login(username, password))
            {
                Console.WriteLine("Login is succesful");


                categoryController.AddCategory("Proqramlaşdırma");
                categoryController.AddCategory("SQL database");


                questionController.AddQuestion("C# nədir?", "Bir proqramlaşdırma dilidir.", "Proqramlaşdırma");
                questionController.AddQuestion("SQL nədir?", "Verilənlər bazası sorğulama dilidir.", "Verilənlər Bazası");


                studentController.AddStudent("Mirvari", "Muradova", "Muradovamirvari@gmail.com", "1234", "Proqramlaşdırma");
                var randomQuestion = questionController.GetRandomQuestion("Proqramlaşdırma");
                if (randomQuestion != null)
                {
                    Console.WriteLine($"Random Sual: {randomQuestion.Text}");

                }


                foreach (var student in studentController.GetStudents())
                {
                    Console.WriteLine($"Student: {student.Name} {student.Surname}, Kateqoriya: {student.QuestionCategory}");
                }
            }
            else
            {
                Console.WriteLine("Password is not correct!");
            }

            Console.ReadLine();
        }
    }



//                var randomQuestion = questionController.GetRandomQuestion("Proqramlaşdırma");
//                if (randomQuestion != null)
//                {
//                    Console.WriteLine($"Random Sual: {randomQuestion.Text}");

//                }


//                foreach (var student in studentController.GetStudents())
//                {
//                    Console.WriteLine($"Student: {student.Name} {student.Surname}, Kateqoriya: {student.QuestionCategory}");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Password is not correct!");
//            }

//            Console.ReadLine();
//        }
//    }
//}
