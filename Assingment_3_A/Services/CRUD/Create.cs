using Assingment_3_A.Models;
using Assingment_3_A.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assingment_3_A.Services.CRUD
{
    internal abstract class Create
    {
        public static void CreateCandidate()
        {
            AppDBContext appDBContext = new AppDBContext();
            Candidate obj = new Candidate();
            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                if (prop.Name == "Id")
                {
                }
                else if (prop.PropertyType == typeof(DateTime))
                {
                    while (true)
                    {
                        Console.WriteLine("enter date in YYYY-MM-DD format");
                        var input = Console.ReadLine();
                        if (DateTime.TryParse(input, out var date))
                        {
                            prop.SetValue(obj, date);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("please try again and enter date in YYYY-MM-DD format");
                        }
                        prop.SetValue(obj, DateTime.Parse(Console.ReadLine()));

                    }

                }


                else if (prop.PropertyType == typeof(string))
                {
                    Console.Write($"{prop.Name}: ");
                    prop.SetValue(obj, Console.ReadLine());
                }



                else if (prop.PropertyType == typeof(int))
                {
                    Console.Write($"{prop.Name}: ");
                    prop.SetValue(obj, int.Parse(Console.ReadLine()));
                }
            }
            appDBContext.Candidates.Add(obj);
            appDBContext.SaveChanges();
        }
    }
}
