namespace Exercise_Warmup
{
    internal class Airport
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public bool IsInternational { get; set; }
        public List<string> Airlines { get; set; }
        public DateTime LastUpdated { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
