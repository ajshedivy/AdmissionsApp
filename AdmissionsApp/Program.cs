using AdmissionsLibrary;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace AdmissionsApp
{
    class Program
    {
        private static string APP_PROMPT = "### Welocome to the Admisson App ###\n\n";
        private static string MENU_PROMPT =
            "" + "======== MENU ========\n" + "[1] Create a Applicant Account\n"
            + "[2] View current application\n" + "[3] Display all applications\n"
            + "[4] Exit\n" + "> ";

        private static List<Applicant> applicantList = new List<Applicant>();
        private static void driver() 
        {
            Console.WriteLine(APP_PROMPT);
            Boolean isterminated = false;
            while (!isterminated)
            {
                Console.WriteLine(MENU_PROMPT);
                isterminated = processCommand();
            }
        }

        private static Boolean processCommand()
        {
            String cmd = Console.ReadLine().Trim();
            switch(cmd)
            {
                case "1": // create new applicant account
                    Console.WriteLine("Enter Applicant name: ");
                    var name = Console.ReadLine();
                    Console.WriteLine("Enter Collage: ");
                    var college = Console.ReadLine();
                    Console.WriteLine("Enter Area of Study: ");
                    var study = Console.ReadLine();
                    Applicant a = new Applicant(name);
                    a.AreaOfStudy = study;
                    a.College = college;
                    Program.applicantList.Add(a);                 
                    break;
                case "2": //search for applicant
                    Console.WriteLine("Enter name: ");
                    var nameSearch = Console.ReadLine();
                    string returnName = null;
                    foreach(Applicant applicant in applicantList)
                    {
                        if (applicant.getName() == nameSearch)
                        {
                            returnName = applicant.ToString();
                            break;
                        }
                    }
                    if (returnName == null)
                    {
                        Console.WriteLine("applicant does not exist, or name is spelled wrong");
                    }
                    else
                    {
                        Console.WriteLine(returnName);
                    }
                    break;
                case "3": // display all applicants
                    foreach (Applicant applicant in applicantList)
                    {
                        Console.WriteLine(applicant.ToString());
                    }
                    break;
                case "4":
                    try
                    {
                        return true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    break;

            }

            return false;
        }
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello World!");
            ////Applicant a = new Applicant("Adam jihn");
            ////Console.WriteLine(a.ApplicantID);
            ////Applicant ab = new Applicant("Adam jihn");
            ////Console.WriteLine(ab.ApplicantID);
            ////Console.WriteLine(a.ToString());
            ////Console.WriteLine(ab.ToString());

            Program program = new Program();
            driver();

        }
    }
}
