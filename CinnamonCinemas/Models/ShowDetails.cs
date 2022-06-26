using System;
namespace CinnamonCinemas.Models
{
	public class ShowDetails
    { 

        public void DisplayShowDetails()
        {
            Dictionary<int, string> showlist = new Dictionary<int, string>()
            {
                {  1, "Thor: Love and Thunder"}, { 2, "SpiderHead"},
                {3, "Harry Potter" },{4, "Frozen"}
            };

            // Use KeyValuePair with foreach on Dictionary.
            foreach (KeyValuePair<int, string> list in showlist)
            {
                
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(" {0} : {1}", list.Key, list.Value);
                
            }
        }
	}
}

