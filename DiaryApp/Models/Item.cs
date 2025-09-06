namespace DiaryApp.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string name { get; set; }

        public Item(string name)
        {
            this.name = name;
        }
    }
}
