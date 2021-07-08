using System.Linq;

namespace DataStructureDemo.DSService
{
    public class DataStructure
    {
        public string LongestString(string text)
        {
            string[] word = text.Split(' ');
            return word.OrderByDescending(w => w.Length).FirstOrDefault();
        }
    }
}
