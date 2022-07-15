﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALL_ClassLibrary;


namespace THE_THREE_CASES
{
    public class LoginMenu
    {
        
        public void RunPasswordMenu()
        {
            string brugernavnFilepath = @"C:\SkrivBord\Brugernavn.txt"; // Username file path
            string adgangskodeFilepath = @"C:\SkrivBord\Adgangskode.txt"; // Username file path


            //PasswordLogic PasswordLogic = new PasswordLogic();
            Main_menu main = new Main_menu();




            bool Continue = false;

            while (Continue == false)
            {


                
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.SetCursorPosition(45, 7);
                Console.Write("---------- Login / Sign-Up ----------");

                Console.SetCursorPosition(45, 10);
                Console.Write("Choose by Typing 1 or 2:");
                Console.SetCursorPosition(45, 12);
                Console.Write("1. Login");

                Console.SetCursorPosition(45, 14);
                Console.Write("2. Sign-Up");
                Console.SetCursorPosition(70, 10);
                
                var choice = Console.ReadLine();


                Console.Clear();

                if (choice == "1")
                {
                    Console.SetCursorPosition(45, 7);
                    Console.Write("---------- Login ----------");

                    Console.SetCursorPosition(45, 10);
                    Console.Write("User: ");
                    string user = Console.ReadLine();

                    Console.SetCursorPosition(45, 12);
                    Console.Write("Password: ");
                    string password = Console.ReadLine();
                    File.WriteAllText(brugernavnFilepath, user);
                    File.WriteAllText(adgangskodeFilepath, password);

                    PasswordLengthandothers(password);
                    TjekHvisDetAlleredeEksisterer(user);
                   
                

                    Console.ReadLine();
                     

                   





                }
                if (choice == "2")
                {
                    Console.SetCursorPosition(45, 7);
                    Console.Write("---------- Sign-Up ----------");

                    Console.SetCursorPosition(45, 10);
                    Console.Write("User: ");
                    string user = Console.ReadLine();

                    Console.SetCursorPosition(45, 12);
                    Console.Write("Password: ");
                    string password = Console.ReadLine();
                    File.WriteAllText(brugernavnFilepath, user);
                    File.WriteAllText(adgangskodeFilepath, password);



                    Console.SetCursorPosition(45, 17);
                    Console.WriteLine("Welcome " + user + " " + "you have created a new account");
                    Console.ReadLine();
                    Console.Clear();

                    Console.SetCursorPosition(45, 7);
                    Console.Write("----------Try Logging in with your new Account ----------");

                    Console.SetCursorPosition(45, 10);
                    Console.Write("User: ");
                    user = Console.ReadLine();

                    Console.SetCursorPosition(45, 12);
                    Console.Write("Password: ");
                    password = Console.ReadLine();
                    File.WriteAllText(brugernavnFilepath, user);
                    File.WriteAllText(adgangskodeFilepath, password);

                    PasswordLengthandothers(password);
                    TjekHvisDetAlleredeEksisterer(user);


                    Console.Clear();




                    ////Main_menu main = new Main_menu();
                    //main.Menu();











                   


                }

                else
                {
                    //Console.WriteLine($"{d}");
                }
                






                //File.WriteAllText(filepath, user + "     " + password);



                //Password.PasswordRequiremnts(password);

                //if (asldklsad)
                //{
                //    Continue = true;


                //    File.ReadAllText(filepath);

                //}


                Console.ReadKey();
            }
        }


        public void TjekHvisDetAlleredeEksisterer(string user)
        {


            Main_menu main = new Main_menu();


            string filepath = @"C:\SkrivBord\Brugernavn.txt";
            string check = File.ReadAllText(filepath);

            if (check.Contains(user))
            {

                Console.SetCursorPosition(45, 20);
                Console.WriteLine("User Exists");
                Console.ReadLine();
                main.Menu();
            }
            else
            {
                RunPasswordMenu();
            }
           
            
        }

        public void PasswordLengthandothers(string password)
        {


            Main_menu main = new Main_menu();

            bool containsAtLeastOneUppercase = password.Any(char.IsUpper);
            bool containsAtLeastOneLowercase = password.Any(char.IsLower);
            string specialChars = "!@#$%^&*()-_+=\\/':,{}[]~.";
            string space = ("  ");
            int minLength = 12;


            if (password.Length < minLength)
            {
                Console.SetCursorPosition(45, 16);
                Console.Write("Password Should have minimum 12 characters!");
                Console.ReadLine ();
                RunPasswordMenu();

            }
            else if (containsAtLeastOneLowercase != containsAtLeastOneUppercase)
            {
                Console.SetCursorPosition(45, 16);
                Console.Write("Password should have atleast one Upper and Lower Case Character!");
                Console.ReadLine();
                RunPasswordMenu();

            }
            else if (!Contains(password, specialChars))
            {
                Console.SetCursorPosition(45, 16);
                Console.Write("Password should have atleast one Special Character!");
                Console.ReadLine();
                RunPasswordMenu();

            }
            else if (Contains(password, space))
            {
                Console.SetCursorPosition(45, 16);
                Console.Write("Password should not have any Spaces!");
                Console.ReadLine();
                RunPasswordMenu();

            }
            else
            {

                main.Menu();
            }



        }

        public bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

    }
}
