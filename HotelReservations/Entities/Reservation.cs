using System;
using HotelReservations.Entities.Exceptions;

namespace HotelReservations.Entities
{
    public class Reservation
    {
        private int RoomNumber { get; set; }
        private DateTime CheckIn { get; set; }
        private DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
                throw new DomainException("Check-out date must be after check-in date.");
            
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        private int Duration()
        {
            var duration = CheckOut.Subtract(CheckIn);
            return (int) duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            var now = DateTime.Now;
            if (checkIn < now || checkOut < now)
                throw new DomainException("Reservation dates for update must be future dates.");

            if (checkOut <= checkIn)
                throw new DomainException("Check-out date must be after check-in date.");

            CheckIn = checkIn;
            CheckOut = checkIn;
        }

        public override string ToString()
        {
            return "RESERVATION: \n" +
                   $"Room: {RoomNumber}\n" +
                   $"Check-In: {CheckIn:dd/MM/yyyy}\n" +
                   $"Check-Out: {CheckOut:dd/MM/yyyy}\n" +
                   $"Spent a total of {Duration()} Nights.";
        }
    }
}