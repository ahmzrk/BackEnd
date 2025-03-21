BackEnd Repository

📌 Proje Hakkında
 C# ile geliştirilmiş katmanlı mimariye sahip, ölçeklenebilir, dinamik ve esnek bir e-ticaret backend uygulamasını içermektedir. Proje, iş kuralları, cache yönetimi, performans optimizasyonları, transaction yönetimi, validation süreçleri ve aspect tabanlı programlama prensiplerini içermektedir. Aynı zamanda, interfaceler ve sınıflar ile modüler bir yapı sunmaktadır.

🚀 Teknolojiler

Projede kullanılan başlıca teknolojiler:

C# / .NET Core / .NET 6+ (Backend geliştirme)

Entity Framework Core (ORM)

SQL Server (Veritabanı yönetimi)

JWT (JSON Web Token) (Kimlik doğrulama ve güvenlik)

Hashing & Encryption (Güvenlik mekanizmaları)

Redis (Cache yönetimi)

Transaction Management (Veri bütünlüğü sağlama)

Aspect Oriented Programming (AOP) (İş kurallarını merkezi olarak yönetme)

📂 Katmanlı Mimari

Entities Layer → Veritabanı varlıklarını içerir.

Data Access Layer (DAL) → Veri tabanı işlemlerini yönetir.

Business Layer → İş kurallarını ve mantıksal süreçleri içerir.

Core Layer → Ortak bileşenler, yardımcı sınıflar, güvenlik ve altyapı servislerini içerir.

API Layer → Dış dünyaya açılan API uç noktalarını barındırır.

Interfaces Layer → Bağımlılığı azaltmak için kullanılan soyutlama katmanı.

🔒 Güvenlik

Kullanıcı kimlik doğrulaması ve yetkilendirme için JWT Authentication kullanılmıştır.

Şifreler güvenli hashing ve encryption algoritmaları ile korunmaktadır.

API istekleri için role-based authorization uygulanmıştır.

