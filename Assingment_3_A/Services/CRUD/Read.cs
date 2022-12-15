using Assingment_3_A.Models;
using Assingment_3_A.Services.Data;
using System;
using System.Linq;
using System.Reflection;


namespace Assingment_3_A.Services.CRUD
{
    internal class Read
    {
        public static void ReadCandidate()
        {
            Console.WriteLine("Give the id of the candidate you want to View");
            AppDBContext appDBContext = new AppDBContext();
            Candidate obj = appDBContext.Candidates.Find(int.Parse(Console.ReadLine()));

            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(obj, null)}");
            }
        }
    }
}
