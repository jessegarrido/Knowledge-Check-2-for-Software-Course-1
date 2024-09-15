namespace KnowledgeCheck2
{

    public class Instrument
    { 
        public string ManufacturerName { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
    }
    public class Guitar : Instrument
    {
        public int NumberOfStrings { get; set; } = 6;
    }
}
