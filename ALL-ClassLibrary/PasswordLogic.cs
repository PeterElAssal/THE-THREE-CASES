﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ALL_ClassLibrary;


namespace ALL_ClassLibrary
{
    public class PasswordLogic
    {
        StringBuilder sb = new StringBuilder();
        public string Password;
        public string UserName;
        public string passwordrequiremnts()
        {
            //    TjekHvisDetAlleredeEksisterer(Password, UserName);
            //    passwordrequiremnts(Password, UserName);


            //    //    //Main_menu main_menu = new Main_menu();
            

            Password = sb.ToString();
            UserName = sb.ToString();   

            //    //    //int minLength = 12;


            //    //    //bool containsAtLeastOneUppercase = password.Any(char.IsUpper);
            //    //    //bool containsAtLeastOneLowercase = password.Any(char.IsLower);
            //    //    //string specialChars = "!@#$%^&*()-_+=\\/':,{}[]~.";
            //    //    //string space = ("  ");
            TjekHvisDetAlleredeEksisterer();
            PasswordLengthandothers();


            return sb.ToString();



            //    //    //if (password.Length < minLength)
            //    //    //{
            //    //    //    Console.SetCursorPosition(45, 16);
            //    //    //    Console.Write("Password should have minimum 12 characters!");

            //    //    //}
            //    //    //else if (containsAtLeastOneLowercase != containsAtLeastOneUppercase)
            //    //    //{
            //    //    //    Console.SetCursorPosition(45, 16);
            //    //    //    Console.Write("Password should have atleast one Upper and Lower Case Character!");

            //    //    //}
            //    //    //else if (!Contains(password, specialChars))
            //    //    //{
            //    //    //    Console.SetCursorPosition(45, 16);
            //    //    //    Console.Write("Password should have atleast one Special Character!");

            //    //    //}
            //    //    //else if (Contains(password, space))
            //    //    //{
            //    //    //    Console.SetCursorPosition(45, 16);
            //    //    //    Console.Write("Password should not have any Spaces!");

            //    //    //}

            //    //    //else
            //    //    //{
            //    //    //    //var obj2 = new Main_menu();
            //    //    //    //obj2.

            //    //    //}



        }


       private void TjekHvisDetAlleredeEksisterer()
        {



            string filepath = @"C:\SkrivBord\Brugernavn.txt";
            string check = File.ReadAllText(filepath);

            if (check.Contains(UserName))
            {

                Console.SetCursorPosition(45, 20);
                Console.WriteLine("User Name Exits!");


            }
            else if (check.Contains(Password))
            {
                Console.SetCursorPosition(45, 20);
                Console.Write("Password Exits!");
            }

        }

        public void PasswordLengthandothers()
        {


            bool containsAtLeastOneUppercase = Password.Any(char.IsUpper);
            bool containsAtLeastOneLowercase = Password.Any(char.IsLower);
            string specialChars = "!@#$%^&*()-_+=\\/':,{}[]~.";
            string space = ("  ");
            int minLength = 12;


            if (Password.Length < minLength)
            {
                Console.SetCursorPosition(45, 16);
                Console.Write("Password Should have minimum 12 characters!");


            }
            else if (containsAtLeastOneLowercase != containsAtLeastOneUppercase)
            {
                Console.SetCursorPosition(45, 16);
                Console.Write("Password should have atleast one Upper and Lower Case Character!");

            }
            else if (!Contains(Password, specialChars))
            {
                Console.SetCursorPosition(45, 16);
                Console.Write("Password should have atleast one Special Character!");

            }
            else if (Contains(Password, space))
            {
                Console.SetCursorPosition(45, 16);
                Console.Write("Password should not have any Spaces!");

            }



        }

        public bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }









    }
}

