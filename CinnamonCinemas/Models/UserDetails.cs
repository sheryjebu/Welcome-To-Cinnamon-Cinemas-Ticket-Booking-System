using System;
namespace CinnamonCinemas.Models
{
	public class UserDetails
	{
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string MovieName { get; set; }
        public DateTime Time { get; set; }
        public int NoOfSeats { get; set; }


        public UserDetails(string name, string emailId, string movieName, DateTime time, int noOfSeats)
        {
            Name = name;
            EmailId = emailId;
            MovieName = movieName;
            Time = time;
            NoOfSeats = noOfSeats;
        }

        public void Login()
        {

        }

        public void NewUser()
        {

        }
        
	}
}

