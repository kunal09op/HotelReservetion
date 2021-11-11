using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservetion.Models
{
    public class Hotel
    {
         public int HotelID { get; set; }
        public string HotelCity { get; set; }
        public string HotelState { get; set; }
        public int HotelZipCode { get; set; }
        public long HotelPhoneNumber { get; set; }
        public int EmployeeID { get; set; }
    }
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public long EmployeePhoneNumber { get; set; }
    }
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public int NumberOfBeds { get; set; }
        public int Charges { get; set; }

    }
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public int CustomerZipCode { get; set; }
        public long CustomerPhoneNumber { get; set; }

    }
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int HotelID { get; set; }
        public int CustomerID { get; set; }
        public int RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
    }
    public class Ratings
    {
        [Key]
        public int CustomerID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
       
    }
    
    public class Billing
    {
        [Key]
        public int BillNumber { get; set; }
        public int ReservationID { get; set; }

        public int TotalCharges { get; set; }
    }
}
