using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Ürün eklendi";
        public static string CarNameInvalid = "CarNameInvalid";
        public static string CarPriceInvalid  = "CarPriceInvalid";
        public static string Listed = "Listelendi";
        public static string AuthorizationDenied= "AuthorizationDenied";
        public static string UserRegistered;
        public static string UserNotFound;
        public static string PasswordError;
        public static string SuccessfulLogin;
        public static string UserAlreadyExists;
        public static string AccessTokenCreated;
    }
}
