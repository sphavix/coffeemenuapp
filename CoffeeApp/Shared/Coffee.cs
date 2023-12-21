namespace CoffeeApp.Shared
{
    public class Coffee
    {
        public int Id { get; set;}
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string[] Ingredients { get; set; }

        public Coffee() {}

        public Coffee (int id, string title, string description, string[] ingredients)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Ingredients = ingredients;
        }
    }
}