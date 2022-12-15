using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Design;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Assingment_3_A.Migrations;
using Assingment_3_A.Models;
using Assingment_3_A.Services.CRUD;
using Assingment_3_A.Services.Data;
using Console_Menu_Assingment_3_A;
using Menu = Console_Menu_Assingment_3_A.Menu;

namespace Assingment_3_A
{
    public class Program
    {
        static void Main(string[] args)
        {

            string SelectedOption;
            SelectedOption = Menu.MenuGenerator("Admin", "Candidate", "Exit");
            if (SelectedOption == "Admin")
            {
                SelectedOption = Menu.MenuGenerator("C R U D", "See Results", "Exit");
                if (SelectedOption == "C R U D")
                {
                    SelectedOption = Menu.MenuGenerator("Create Candidate", "Read Candidate", "Update Candidate", "Delete Candidate");
                    if (SelectedOption == "Create Candidate")
                    {
                        Create.CreateCandidate();
                    }
                    else if (SelectedOption == "Read Candidate")
                    {
                        Read.ReadCandidate();
                    }
                    else if (SelectedOption == "Update Candidate")
                    {
                        Update.UpdateCandidate();
                    }
                    else if (SelectedOption == "Delete Candidate")
                    {
                        Delete.DeleteCandidate();
                    }
                    else
                    {
                        return;
                    }
                }
                else if (SelectedOption == "See Results")
                {
                    Result.CandidateResults();
                }
                else
                {
                    return;
                }
            }
            else if (SelectedOption == "Candidate")
            {

                SelectedOption = Menu.MenuGenerator("List of Candidate’s Certificates", "Export of Candidate’s Certificates in a .pdf forma", "Exit");
                if (SelectedOption == "List of Candidate’s Certificates")
                {
                    CanadidateCertificate.CandidateCertificates();
                }
                else if (SelectedOption == "Export of Candidate’s Certificates in a .pdf forma")
                {
                    Console.WriteLine("Yeasss sureeeee, ti wra??????");
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }



        }



















        //AppDBContext appDBContext= new AppDBContext();

        //    var cert = appDBContext.Certificates
        //        .Where((c => c.Id == 1)).FirstOrDefault();
        //    appDBContext.Entry(cert).Collection(c => c.CertificateTopics).Load();
        //    foreach (var certTopip in cert.CertificateTopics)
        //    {
        //        Console.WriteLine(certTopip);
        //    }
        //    Console.WriteLine(cert);

        
    }
}

