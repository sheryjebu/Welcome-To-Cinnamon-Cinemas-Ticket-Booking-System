using System;
namespace CinnamonCinemas.Models
{
	public class SeatingArrangement
	{
        public string[,] Seats = new string[3, 2];

        public SeatingArrangement(string[,] seats)
        {
            Seats = seats;
        }

        public void ShowSeats(string[,] seats)
        {
            string display = string.Empty;
            for (int row = 0; row < seats.GetLength(0); row++)
            {
                int seatPerRow = seats.GetLength(1);
                int index = seatPerRow-1;

                for (int column = 0; column <=index; column++)
                {
                    display += seats[row, column] + " ";
                }
                display += "\n";
            }
            Console.WriteLine(display);
        }

    }
}

