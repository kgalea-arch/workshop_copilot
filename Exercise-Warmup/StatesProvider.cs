namespace Exercise_Warmup
{
    public class StatesProvider
    {
        // Returns the list of all federal states of Germany
        public ICollection<string> GetAllStatesOfGermany()
        {
            // Replace this comment with your implementation
            return new List<string> { "Bavaria", "Berlin", "Brandenburg", "Bremen", "Hamburg", "Hesse", "Lower Saxony", "Mecklenburg-Vorpommern", "North Rhine-Westphalia", "Rhineland-Palatinate", "Saarland", "Saxony", "Saxony-Anhalt", "Schleswig-Holstein", "Thuringia" };
        }

        // Returns the list of all federal states of Austria
        public ICollection<string> GetAllStatesOfAustria()
        {
            return new List<string> { "Burgenland", "Carinthia", "Lower Austria", "Upper Austria", "Salzburg", "Styria", "Tyrol", "Vorarlberg", "Vienna" };
        }

        // Returns the list of all federal states of Switzerland
        public ICollection<string> GetAllStatesOfSwitzerland()
        {
            return new List<string> { "Aargau", "Appenzell Ausserrhoden", "Appenzell Innerrhoden", "Basel-Landschaft", "Basel-Stadt", "Bern", "Fribourg", "Geneva", "Glarus", "Graubünden", "Jura", "Lucerne", "Neuchâtel", "Nidwalden", "Obwalden", "Schaffhausen", "Schwyz", "Solothurn", "St. Gallen", "Thurgau", "Ticino", "Uri", "Valais", "Vaud", "Zug", "Zurich" };
        }
    }
}
