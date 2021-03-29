using Serilog;
using System;
using System.Reflection;

namespace HW._11.ReppositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Hour, rollOnFileSizeLimit: true)
                .CreateLogger();

            Log.Information($"Name of project: {Assembly.GetEntryAssembly().GetName().Name}");
            Log.Information($"Project at machine {Environment.MachineName} succesfully started by {Environment.UserName}");

            MotorcycleRepository moto = new();

            Motorcycle moto1 = new() { Id = Guid.NewGuid(), Model = "Minsk", Name = "Cite", Year = 2021, Odometr = 30000 };
            Motorcycle moto2 = new() { Id = Guid.NewGuid(), Model = "Moscow", Name = "Moe", Year = 2017, Odometr = 60000 };

            moto.Create(moto1);
            moto.Create(moto2);
            moto.Delete(moto1.Id);
            moto.Update(moto2.Id);
            moto.Create(moto.GetByID(moto2.Id));

            foreach (Motorcycle item in moto.GetAll())
            {
                Log.Information("The process of output motoList to the console has started");
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Odometr);
                Console.WriteLine(item.Year);
            }

            Log.Information("Termination of the program");
        }
    }
}