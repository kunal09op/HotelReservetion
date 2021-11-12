using NUnit.Framework;
using HotelReservetion.Controllers;
using HotelReservetion.Models;
using System.Web.Http.Results;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelReservetion.Test
{
    [TestFixture]
    public class Tests
    {
        HotelsController hotelsController;
        EmployeesController employeesController;
        CustomersController customersController;
        ReservationsController reservationsController;
        RoomsController roomsController;
        BillingsController billingsController;
        RatingsController ratingsController;
        HotelDbContext _context;
        [SetUp]
        public void Setup()
        {
            hotelsController = new HotelsController(_context);
            employeesController = new EmployeesController(_context);
            customersController = new CustomersController(_context);
            reservationsController = new ReservationsController(_context);
            roomsController = new RoomsController(_context);
            billingsController = new BillingsController(_context);
            ratingsController = new RatingsController(_context);
        }
        [Test]
        public void TestGetHotel()
        {
            var result = hotelsController.GetHotel();
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetEmployee()
        {
            var result = employeesController.GetEmployee();
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetCustomer()
        {
            var result = customersController.GetCustomer();
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetReservation()
        {
            var result = reservationsController.GetReservation();
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetRoom()
        {
            var result = roomsController.GetRoom();
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetBilling()
        {
            var result = billingsController.GetBilling();
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetRating()
        {
            var result = ratingsController.GetRatings();
            Assert.IsNotNull(result);
        }
        // Get By Id
        [Test]
        public void TestGetHotelById()
        {
            var result = hotelsController.GetHotel(301);
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetEmployeeById()
        {
            var result = employeesController.GetEmployee(1);
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetCustomerById()
        {
            var result = customersController.GetCustomer(201);
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetReservationById()
        {
            var result = reservationsController.GetReservation(401);
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetRoomById()
        {
            var result = roomsController.GetRoom(101);
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetBillingById()
        {
            var result = billingsController.GetBilling(501);
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetRatingById()
        {
            var result = ratingsController.GetRatings(601);
            Assert.IsNotNull(result);
        }

    }
}