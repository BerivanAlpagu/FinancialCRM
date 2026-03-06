🚀 My Financial CRM Project
A modern, N-Tier architecture Financial Management System built with ASP.NET Core 8.0 and PostgreSQL. This project aims to provide a clean and professional dashboard for tracking banks, bills, and expenditures.

ASP.NET Core 8.0 ve PostgreSQL kullanılarak N-Tier (N-Katmanlı) mimari ile geliştirilmiş modern bir Finansal Yönetim Sistemi. Bu proje, bankaları, faturaları ve giderleri takip etmek için temiz ve profesyonel bir panel sunmayı amaçlamaktadır.

📸 Project Tour / Proje Turu
1. Secure Login / Güvenli Giriş
* EN: A secure gateway to protect your financial data. Only authenticated users can access the dashboard, view bank details, and manage sensitive billing information.

TR: Finansal verilerinizi korumak için güvenli bir giriş kapısı. Yalnızca yetkili kullanıcılar panele erişebilir, banka detaylarını görüntüleyebilir ve hassas fatura bilgilerini yönetebilir.
<img width="1912" height="862" alt="image" src="https://github.com/user-attachments/assets/cc41bbef-f51e-4525-b94c-6cd1bc1c65d9" />

2. Dashboard Page / Panel Sayfası
EN: This is the main hub of the application. It features a modern sidebar (Ricochet style) and provides a summary of financial status using charts and cards.

TR: Uygulamanın ana merkezidir. Modern bir yan menüye (Ricochet tarzı) sahiptir ve grafikler ile kartlar kullanarak finansal durumun özetini sunar.
<img width="1919" height="854" alt="image" src="https://github.com/user-attachments/assets/59257e45-b075-4d0d-99ce-f715c5b4d853" />

3. Banks & Accounts / Bankalar ve Hesaplar
EN: Users can monitor, add, and update their bank balances and account details. The data is pulled dynamically from the database using an asynchronous service layer.

TR: Kullanıcılar banka bakiyelerini ve hesap detaylarını izleyebilir, ekleyebilir ve güncelleyebiler. Veriler, asenkron bir servis katmanı aracılığıyla veri tabanından dinamik olarak çekilir.
<img width="1916" height="862" alt="image" src="https://github.com/user-attachments/assets/79cffa83-f2cb-40ac-965a-5377dc7ce864" />
<img width="1919" height="872" alt="image" src="https://github.com/user-attachments/assets/c244d4d3-97de-4be5-89a8-e93827357fdf" />
<img width="1917" height="863" alt="image" src="https://github.com/user-attachments/assets/39e13246-1236-4bff-884e-1dc3af7adcc2" />

4. Billing & Payments / Faturalar ve Ödemeler
EN: This section allows users to create, delete, and list bills. It includes English validation and period formatting (e.g., March 2026).

TR: Bu bölüm kullanıcıların fatura oluşturmasına, silmesine ve listelemesine olanak tanır. İngilizce doğrulama ve dönem formatlaması (örneğin; Mart 2026) içerir.
<img width="1919" height="864" alt="image" src="https://github.com/user-attachments/assets/322a7643-1bf1-4731-af63-9c274dbe2432" />
<img width="1919" height="863" alt="image" src="https://github.com/user-attachments/assets/f42fdd3e-7853-4ae9-9861-ab9f02378646" />

5. Category Management / Kategori Yönetimi
* EN: Organize your expenses and bills efficiently. This section allows you to create, update, and delete categories to track your spending habits by type (e.g., Food, Rent, Entertainment).

TR: Giderlerinizi ve faturalarınızı verimli bir şekilde düzenleyin. Bu bölüm, harcama alışkanlıklarınızı türe göre (örneğin; Gıda, Kira, Eğlence) takip edebilmeniz için kategoriler oluşturmanıza, güncellemenize ve silmenize olanak tanır.
<img width="1918" height="860" alt="image" src="https://github.com/user-attachments/assets/b5f4cb34-445d-4475-95c2-23a95ea82495" />



🛠 Technical Features / Teknik Özellikler
Architecture / Mimari: N-Tier Architecture (Entity, DataAccess, Business, WebUI).

Database / Veri Tabanı: PostgreSQL with Entity Framework Core.

Security / Güvenlik: sensitive data (Connection Strings) managed via User Secrets for local development.

UI/UX: Responsive design using Bootstrap 5, FontAwesome, and Inter Google Fonts.

Notifications: Integrated SweetAlert2 for user-friendly delete confirmations and success messages.

⚙️ How to Run / Nasıl Çalıştırılır?
Clone the repo / Repoyu klonlayın: git clone <repo-url>

Database Connection / Veri Tabanı Bağlantısı:

Initialize your connection string in secrets.json.

Secrets.json format:

JSON
{
  "ConnectionStrings": {
    "FinancialCrmConnection": "Host=localhost;Database=CrmDb;Username=postgres;Password=your_password"
  }
}
Run Migrations / Migrationları Çalıştırın: Update-Database

Launch / Başlatın: Press F5 in Visual Studio.
