namespace Exercise_Context
{
    internal class ParseByExample
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }

        public string ParseExample()
        {
            return $"Name: {Name}, Location: {Location}, Capacity: {Capacity}";
        }
    }
}
