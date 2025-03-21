using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";



        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        internal static string ProductNameAlreadyExist = "Bu isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceed = "Kategori limiti aşıldı";
        internal static string AuthorizationDenied = "Yetkiniz yok";
        internal static string UserRegistered = "Kayıt olundu";
        internal static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string PasswordError = "Yanlış şifre";
        internal static string SuccessfulLogin = "Giriş yapıldı";
        internal static string UserAlreadyExists = "Böyle bir kullanıcı zaten var";
        internal static string AccessTokenCreated = "İzin verildi";
    }
}
