using System;
namespace CinnamonCinemas.Models
{
    public class BookNow
    {
        //public string MovieName { get; set; }
       // public DateTime Time { get; set; }
        public int NoOfSeats { get; set; }
        public string[,] Seats { get; set; }

        public BookNow(/*string movieName, */int noOfSeats, string[,] seats)
        {
            //MovieName = movieName;
            //Time = time;
            NoOfSeats = noOfSeats;
            Seats = seats;
        }

        //public bool BookSeats(string movieName, int noOfSeats, string[,] seats)
        public void BookSeats(int noOfSeats, string[,] seats)
        {
            /* string[,] empty_seats = new string[,]
             {
                  {"0", "0", "0", "0","0"},
                  {"0", "0", "0", "0","0"},
                  {"0", "0", "0", "0","0"},
             }; */
            string display = string.Empty;
            int seatPerRow = 5;
            int index = seatPerRow-1;

            for (int row = 0; row < 3; row++)
            {
                // index++;

                if (noOfSeats < seatPerRow) { index = noOfSeats-1; }
               
                    for (int column = index; column>=0; column--)
                    {
                        if (seats[row, column] != "X")
                        {
                            Console.WriteLine("Booking seat...");
                            Console.WriteLine("Row: " + row.ToString());
                            Console.WriteLine("Column: " + column.ToString());
                            seats[row, column] = "X";
                            Console.WriteLine("We have now booked this seat for you.");
                            noOfSeats--;
                       }
                    }
                //break;
                //}

                //We scanned the whole theatre without finding an empty seat:
                //Console.WriteLine("Sorry the theatre is full - Cannot make a booking");
                //Console.WriteLine(display);
            }
        }

        public void displayBookings()
        {

        }
        public void bookSeatAtFront()
        {

        }
        public void bookSeatAtBack()
        {
        }
       
    }
}

