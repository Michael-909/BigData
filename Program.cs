using System;

namespace BigData
{
    class Program
    {
        static void Main(string[] args)
        {
            JvEdmController controller = new JvEdmController();

            string json = System.IO.File.ReadAllText(@"D:\WorkTempFolder\BigData\model.json");

            var result = controller.updateDmReportJournal("d747048d", json);

            Console.WriteLine(result.ToString());
        }
    }
}
