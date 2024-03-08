using Business;
using DataAccess.Entities;
using DataAccess.Repositories;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Serialization;


namespace RehberUygulaması
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AppRepository appRepository = new AppRepository();
            appRepository.CheckRepository();
            Application.Run(new HomePage());  
           
            
        }
    }
}