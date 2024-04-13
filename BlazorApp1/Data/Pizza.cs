namespace BlazorApp1.Data
{
    public class Pizza
    {
        public string Naming { get; set; }
        public string Compound { get; set; }
        public int Cost { get; set; }
        public string ImageUrl { get; set; }

        public Pizza(string naming, string compound, int cost, string imageUrl)
        {
            Naming = naming;
            Compound = compound;
            Cost = cost;
            ImageUrl = imageUrl;
        }
    }
}
