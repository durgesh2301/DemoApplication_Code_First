using DALLayer;
using DALLayer.Migrations;

namespace ConsoleApp
{
    public class Program
    {
        static Repository repository;
        static DemoDBContext demoDBContext;

        static Program()
        {
            demoDBContext = new DemoDBContext();
            repository = new Repository(demoDBContext);
        }
        static void Main(string[] args)
        {
            //var categories = repository.GetAllCategories();

            //if (categories != null && categories.Count > 0)
            //{
            //    foreach (var category in categories)
            //    {
            //        Console.WriteLine($"Category ID: {category.CategoryId}, Name: {category.CategoryName}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No categories found.");
            //}
        }
    }
}
