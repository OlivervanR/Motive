using System.Collections.ObjectModel;

namespace Test.Model
{
    public class Group
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Account> People { get; set; }
    }
}
