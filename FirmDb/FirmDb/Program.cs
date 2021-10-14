using FirmDb.Data;
using FirmDb.Presentation;
using System;

namespace FirmDb
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductContext db = new ProductContext();
            db.Database.EnsureCreated();
            Display display = new Display();
        }
    }
}
