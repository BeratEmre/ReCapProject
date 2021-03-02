﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string Added = "Car is added";

        public static string NotAdded = "The car could not be added";

        public static string Deleted = "Car is deleted!";

        public static string GetAll = "All cars would bring";

        public static string CarGet = "Car was brought";

        public static string Updated = "Car is modified";

        public static string GetRentalDetails = "Rental details were brought";

        public static string CustomerAded = "Customer aded";

        public static string CustomerDeleted = "Customer deleted!";
        public static string GetAllCustomer = "All customers would bring";

        public static string CustomerUpdated = "Customer updated";

        public static string UserUpdated = "User updated";

        public static string GetAllUser ="All users would bring";

        public static string UserDeleted = "User deleted!";

        public static string UserAded = "User aded";

        public static string RentalAdded = "The car is rented";

        public static string RentalAddedError = "The car was not rented ";

        public static string RentalGetall = "All rental is load";

        public static string RetalDetails = "Rentals detail is loading";

        public static string UserGetted = "User was brought";
        public static string ImageAded = "CarImage aded";
        public static string CarImageGetAll="All carImages load";
        public static string CarImageDeleted="Car Image Deleted";
        public static string CarImageUpdated="CarImage updated";
        public static string ImageCount="Car ımage count can be max 4";
        public static string GetAllCars="All cars getted";

        public static string AuthorizationDenied = "You are not authorized";
    }
}
