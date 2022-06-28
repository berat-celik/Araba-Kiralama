using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarDailyPriceInvalid = "Arabanın günlük fiyatı 0'dan yüksek olmalıdır";
        public static string CarAdded = "Araba başarıyla eklendi";
        public static string CarUpdated = "Araba başarıyla güncellendi";
        public static string CarDeleted = "Araba silindi";
        public static string BrandNameInvalid = "Arabanın markası en az iki karakter olmalıdır";
        public static string BrandAdded = "Marka başarıyla eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka başarıyla güncellendi";
        public static string CustomerAdded = "Müşteri başarıyla eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi";
        public static string UserPasswordInvalid = "Şifreniz en az 5 karakterli olmalıdır";
        public static string UserAdded = "Kullanıcı başarıyla eklendi";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi";
        public static string ReturnDateIsNull = "Araba teslim edilmeden kiralanmış sayılmaz";
        public static string RentedCar = "Araba başarıyla kiralandı";
        public static string ErrorRent = "Kiralanmak istenen araba zaten kiralanmıştır";
        public static string RentDeleted = "İşlem silindi";
        public static string RentUpdated = "İşlem güncellendi";
        public static string InvalidData = "Aradığınız kritere uygun bir data bulunmamaktadır";
    }
}
