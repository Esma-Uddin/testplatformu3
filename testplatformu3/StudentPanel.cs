using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testplatformu3


   
    {
        public class StudentPanel
        {
            private StudentController studentController = new StudentController();

            
            public void Start()
            {
                while (true)
                {
                    Console.WriteLine("1. Kayıt Ol\n2. Giriş Yap\n3. Çıkış");
                    Console.Write("Bir seçenek seçin: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            SignUp();
                            break;
                        case "2":
                            SignIn();
                            break;
                        case "3":
                            return;
                        default:
                            Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                            break;
                    }
                }
            }

           
            private void SignUp()
            {
                Console.Write("Ad: ");
                string name = Console.ReadLine();
                Console.Write("Soyad: ");
                string surname = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Şifre: ");
                string password = Console.ReadLine();
                Console.Write("Soru Kategorisi: ");
                string questionCategory = Console.ReadLine();

                studentController.AddStudent(name, surname, email, password, questionCategory);
            }

            
            private void SignIn()
            {
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Şifre: ");
                string password = Console.ReadLine();

                if (studentController.Login(email, password))
                {
                    Console.WriteLine("Giriş başarılı. Sınav yapmak için hazır.");
                    ConductExam(); 
                }
                else
                {
                    Console.WriteLine("Please check your mail or password");
                }
            }

            
            private void ConductExam()
            {
                
                Console.WriteLine("exam starting");
                
            }
        }
    }


