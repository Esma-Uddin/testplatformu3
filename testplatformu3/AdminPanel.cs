using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testplatformu3
{
    internal class AdminPanel
    {
        
            private AdminController adminController = new AdminController();

            
            public void Start()
            {
                while (true) 
                {
                    Console.WriteLine("1. Admin Girişi\n2. Öğrenci Girişi\n3. Çıkış");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        if (Login())
                        {
                           // ShowAdminPanel();
                        }
                        else
                        {
                            Console.WriteLine("Giriş başarısız. Tekrar deneyin.");
                        }
                    }
                    else if (choice == "2")
                    {
                        
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("Programdan çıkılıyor.");
                        return; 
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçenek. Lütfen geçerli bir seçenek girin.");
                    }
                }
            }

            
            private bool Login()
            {
                Console.Write("Admin adı: ");
                string name = Console.ReadLine();
                Console.Write("Şifre: ");
                string password = Console.ReadLine();
                return adminController.Login(name, password);
            }
        }
}
