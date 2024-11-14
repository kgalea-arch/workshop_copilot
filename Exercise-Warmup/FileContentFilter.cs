namespace Exercise_Warmup
{
    internal class FileContentFilter
    {
        public void FilterFileContent(string filePath, string keyword, string outputFilePath)
        {
            // Read all lines from the input file
            using (StreamReader reader = new StreamReader(filePath))
            {
                List<string> filteredLines = new List<string>();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(keyword))
                    {
                        filteredLines.Add(line);
                    }
                }

                // Write the filtered lines to the output file
                File.WriteAllLines(outputFilePath, filteredLines);
            }
        }
    }
}
