namespace KnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello, World!");
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());
            var recordList = new List<Guitar>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myClass = new Guitar();
                Console.Write("Enter a Manufacturer Name: ");
                myClass.ManufacturerName = Console.ReadLine();
                Console.Write("Enter a Model Name: ");
                myClass.ModelName = Console.ReadLine();
                Console.Write("Enter a Number of Strings: ");
                myClass.NumberOfStrings = int.Parse(Console.ReadLine());
                recordList.Add(myClass);
            }
            // Print out the list of records using Console.WriteLine()    
            foreach (Guitar guitar in recordList)
            {
                Console.WriteLine($"Manufacturer Name: {guitar.ManufacturerName}");
                Console.WriteLine($"Model Name: {guitar.ModelName}");
                Console.WriteLine($"Number of Strings: {guitar.NumberOfStrings}");
            }
        }
    }
}
