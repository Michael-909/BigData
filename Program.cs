using Newtonsoft.Json;
using System;

namespace BigData
{
    class Program
    {
        static void Main(string[] args)
        {
            JvEdmController controller = new JvEdmController();

            string json = System.IO.File.ReadAllText(@"D:\WorkTempFolder\BigData\model.json");
            var data = JsonConvert.DeserializeObject<Models.DmReportJournal>(json);
            var result = controller.CreateDmReportJournal(data);

            Console.WriteLine(result.ToString());
        }
    }
}
