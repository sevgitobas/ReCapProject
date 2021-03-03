using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarDailyPriceInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        
        public static string CarAdded = "Ürün eklendi";
        public static string CarListed = "Ürünler listelendi";
        public static string CarDeleted = "Ürün silindi";
        public static string CarUpdated = "Ürün güncellendi";
        
        public static string RentalAddedError = "Kiralama bilgisi ekleme başarısız";
        public static string RentalAdded = "Kiralama bilgisi ekleme başarılı";
        public static string RentalDeleted = "Kiralama bilgisi silindi";
        public static string RentalUpdated = "Kiralama bilgisi güncellendi";
        
        public static string BrandListed = "Marka bilgisi listelendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandDeleted = "Marka bilgisi silindi";
        public static string BrandUpdated = "Marka bilgisi güncellendi";
        
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserListed = "Kullanıcı listelendi";
        
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerListed = "Müşteri listelendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        
        public static string ColorListed = "Renk bilgisi listelendi";
        public static string ColorAdded = "Renk bilgisi eklendi";
        public static string ColorDeleted = "Renk bilgisi silindi";
        public static string ColorUpdated = "Renk bilgisi güncellendi";
        
        public static string CarImageListed = "Araç görselleri listelendi";
        public static string CarImageDeleted = "Araç görseli silindi";
        public static string CarImageAdded = "Araç görseli eklendi";
        public static string CarImageUpdated = "Araç görseli güncellendi";
        public static string CarImageLimitExceded = "Araç görseli max sınıra ulaştı";
    }
}
