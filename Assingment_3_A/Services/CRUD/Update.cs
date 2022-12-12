using Assingment_3_A.Models;
using Assingment_3_A.Services.Data;
using System;
using System.Data.Entity.Migrations;
using System.Reflection;
using System.Windows.Forms;

namespace Assingment_3_A.Services.CRUD
{
    internal class Update
    {
        public static void UpdateCandidate()
        {
            Console.WriteLine("Give the id of the candidate you want to update");
            AppDBContext appDBContext = new AppDBContext();
            Candidate obj = appDBContext.Candidates.Find(int.Parse(Console.ReadLine()));

            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {

                if (prop.Name == "Id")
                {

                }
                else if (prop.PropertyType == typeof(DateTime))
                {
                    Console.Write($"{prop.Name}: ");
                    var propValue = prop.GetValue(obj, null).ToString();
                    SendKeys.SendWait(propValue);
                    prop.SetValue(obj, DateTime.Parse(Console.ReadLine()), null);

                }
                else if (prop.PropertyType == typeof(string))
                {
                    Console.Write($"{prop.Name}: ");
                    var propValue = $"{prop.GetValue(obj, null)}";
                    SendKeys.SendWait(propValue);
                    prop.SetValue(obj, Console.ReadLine(), null);
                }
                else if (prop.PropertyType == typeof(int))
                {
                    Console.Write($"{prop.Name}: ");
                    var st = prop.GetValue(obj, null);
                    SendKeys.SendWait(st as string);
                    prop.SetValue(obj, int.Parse(Console.ReadLine()), null);
                }
            }
            appDBContext.Candidates.AddOrUpdate(obj);
            appDBContext.SaveChanges();
        }

    }
}
