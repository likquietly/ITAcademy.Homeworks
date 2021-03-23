using Serilog;
using System;
using System.Collections.Generic;

namespace HW._11.ReppositoryPattern
{
    class MotorcycleRepository : IRepository<Motorcycle>
    {
        private static List<Motorcycle> listMoto = new();

        public void Create(Motorcycle item)
        {
            listMoto.Add(item);
            Log.Information($"Create Motorcycle with id {item.Id}");
        }

        public void Delete(Guid id)
        {
            Motorcycle moto = listMoto.Find(i => i.Id == id);
            if (moto != null)
                listMoto.Remove(moto);
            Log.Information($"Delete Motorcycle with id {id}");
        }

        public Motorcycle GetByID(Guid id)
        {
            Log.Information($"Get Motorcycle by id {id}");
            return listMoto.Find(i => i.Id == id);
        }

        public List<Motorcycle> GetAll()
        {
            Log.Information("Get All Motorcycle List");
            return listMoto;
        }

        public void Update(Guid id)
        {
            try
            {
                foreach (Motorcycle item in listMoto)
                {
                    if (item.Id == id)
                    {
                        item.Id = Guid.NewGuid();
                        Console.WriteLine($"New Guid id: {item.Id}");

                        Console.WriteLine("Please input new Name: ");
                        item.Name = Console.ReadLine();

                        Console.WriteLine("Please input new Model: ");
                        item.Model = Console.ReadLine();

                        Console.WriteLine("Please input new Year: ");
                        item.Year = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Please input new Odometr: ");
                        item.Odometr = Int32.Parse(Console.ReadLine());

                        Log.Information($"Update Motorcycle with id {item.Id}");
                        return;
                    }
                }
                Log.Error($"Update Motorcycle with id {id} failed");
            }
            catch (Exception ex) { Log.Fatal(ex.Message); }
        }
    }
}