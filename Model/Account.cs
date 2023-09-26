namespace Test.Model
{
    public class Account
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string BImage { get; set; }
        public string Friends { get; set; }
        public string Invites { get; set; }
        public string ThisWeek { get; set; }
        public List<string> Gallery { get; set; }
        public List<string> Interests { get; set; }
        public List<List<string>> Favorites { get; set;}

    }
}
