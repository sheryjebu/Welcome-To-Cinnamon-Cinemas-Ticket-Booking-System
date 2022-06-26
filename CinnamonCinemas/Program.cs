// See https://aka.ms/new-console-template for more information
using System;
using Npgsql;

namespace CinnamonCinemas.Models
{
    class Program
    {
     
        static void  Main()
        {
            string? movieID = null;
            string? val = null;
            int noOfSeats = 0;
            string[,] codes = new string[,]
            {
                {"A1", "A2", "A3", "A4","A5"},
                {"B1", "B2", "B3", "B4","B5"},
                {"C1", "C2", "C3", "C4","C5"},
            };

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Yellow;
            

            // Display current Foreground color
            Console.WriteLine("======================================");
            Console.WriteLine(" Welcome To Cinnamon Cinemas 🍿 🎬 ");
            Console.WriteLine("======================================");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine(" ");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("     Upcomming Shows For You! ");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // display the list of shows and time
            ShowDetails showDetails = new ShowDetails();
            showDetails.DisplayShowDetails();

            // Select the show number
            Console.WriteLine(" ");
            Console.WriteLine("** Select the show number (ex: 1) : ");
            movieID = Console.ReadLine();
            Console.WriteLine();


            //bookNow - Y/N

            string? bookNow = null;
            Console.WriteLine("Would You Like to Book Your Seats Now? Yes or No [Y/N]");
            bookNow = Console.ReadLine();
            if (bookNow == "Y")
            {
                Console.WriteLine("** Enter the number of seats : ");
                val = Console.ReadLine();
                // convert to integer
                noOfSeats = Convert.ToInt32(val);
                
                //BookNow bookseat = new BookNow( movieName, noOfSeats );
                BookNow bookseat = new BookNow( noOfSeats, codes);
                bookseat.BookSeats(noOfSeats, codes);
            }
            else if (bookNow =="N")
            {
                Console.WriteLine(" Sorry, Book Your Seats Next Time");
            }
            else
            {
                Console.WriteLine(" Invalid selection! Please try again after some time");
            }


            //if Y then enter the user name, email, no of seats
            // display seating arrangement

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" ");

            Console.WriteLine("Seating Arrangement ");
            SeatingArrangement showseats = new SeatingArrangement(codes);
            showseats.ShowSeats(codes);

            //Choose seat type 1. bookfront, book back, any
            //bookseats - booked seats change to greentext or append as A1-B (Booked), A1- Av(Available)
            // show booked seats


            

        }
    }
}