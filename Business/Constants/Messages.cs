using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string MaintenanceTime = "System is Under Maintenace!";

        //for the CarManager
        public static string CarAdded = "Car Added!" ;
        public static string CarNameInvalid = "Car Name Must be more than two letters!";
        public static string CarListed = "Car Listed!";
        public static string CarDeleted = "Car Deleted!";
        public static string CarUpdated = "Car Updated!";

        //for the BrandManager
        public static string BrandAdded = "Brand Added!";
        public static string BrandListed = "Brand Listed!";
        public static string BrandDeleted = "Brand Deleted!";
        public static string BrandUpdated = "Brand Updated!";

        //for the ColorManager
        public static string ColorAdded = "Color Added!";
        public static string ColorListed = "Color Listed!";
        public static string ColorDeleted = "Color Deleted!";
        public static string ColorUpdated = "Color Updated!";

        //for the UserManager
        public static string UserAdded = "User Added!";
        public static string UserListed = "User Listed!";
        public static string UserDeleted = "User Deleted!";
        public static string UserUpdated = "User Updated!";

        //for the CustomerManager
        public static string CustomerAdded = "Customer Added!";
        public static string CustomerListed = "Customer Listed!";
        public static string CustomerDeleted = "Customer Deleted!";
        public static string CustomerUpdated = "Customer Updated!";

        //for the RentalManager
        public static string RentalAdded = "Rental Added!";
        public static string RentalNameInvalid = "Rental Name Must be more than two letters!";
        public static string RentalListed = "Rental Listed!";
        public static string RentalDeleted = "Rental Deleted!";
        public static string RentalUpdated = "Rental Updated!";
    }
}
