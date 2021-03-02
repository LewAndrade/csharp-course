using System;
using System.Globalization;
using HotelReservations.Entities;
using HotelReservations.Entities.Exceptions;

namespace HotelReservations
{
    class Program
    {
        static void Main(string[] args)
        {
            var cultureInfo = new CultureInfo("pt-BR");
            try
            {
                Console.Write("Room Number: ");
                var roomNumber = int.Parse(Console.ReadLine() ?? string.Empty);
                Console.Write("Check-In date (dd/MM/yyyy): ");
                var checkIn = DateTime.Parse(Console.ReadLine() ?? string.Empty, cultureInfo);
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                var checkOut = DateTime.Parse(Console.ReadLine() ?? string.Empty, cultureInfo);

                var reservation = new Reservation(roomNumber, checkIn, checkOut);

                Console.WriteLine(reservation.ToString());
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-In date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine() ?? string.Empty, cultureInfo);
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine() ?? string.Empty, cultureInfo);

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reservation.ToString());
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}