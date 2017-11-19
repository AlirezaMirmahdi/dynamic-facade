using System;
using BOLProject.BOL.SystemBOL.Facade;
using Rastinware.CRM.UI.Web.Api.BOL.SearchBol;
using BOLProject.BOL.BOL.UserBol;

namespace FacadeTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new Facade();
            Console.WriteLine($"Hi this is my sample project of dynamic facade");
            Console.WriteLine();

            Console.WriteLine($"calling firts facade example:");
            Console.WriteLine(facade.GetBol<SearchBol>().QuickSearch("my search text!!!"));
            Console.WriteLine();

            Console.WriteLine($"calling second facade example:");
            Console.WriteLine(facade.GetBol<UserBol>().GetUserNameById(123456));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
