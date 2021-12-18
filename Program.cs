using CodeFirstDemo.Models;
using System;
using System.Linq;

namespace CodeFirstDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            db.Database.EnsureCreated();
        }
    }
}
