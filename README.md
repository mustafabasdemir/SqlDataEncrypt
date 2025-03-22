# MSSQL Veritabanı Düzeyinde Şifreleme — Always Encrypted Özelliğini Yapılandırma ve .NET Core Uygulamasında Kullanma

## Always Encrypted Nedir?

Always Encrypted, Microsoft SQL Server’ın veri gizliliği ve güvenliği için sunduğu bir özelliktir. AE, hassas verileri şifreleyerek sadece yetkili uygulamaların bu verilere erişmesini sağlar.

### Bu mekanizma sayesinde:
- Hassas veriler sunucu tarafında şifreli tutulur.
- Verilere erişim ancak istemci tarafından doğrulanan sertifikalar aracılığıyla mümkün olur.
- Sunucu yöneticileri veya veritabanı yöneticileri (DBA) gibi yüksek yetkiye sahip kişiler bile şifrelenmiş verilere doğrudan erişemez. Bu özellik, örneğin bir çalışanın kötü niyetli bir veri sızdırma girişimini engelleyebilir. Ayrıca, bir şirketin müşteri bilgilerini içeren yedekleme dosyasının yanlışlıkla dış kaynaklı bir ekiple paylaşılması durumunda, bu ekip şifreli verilerin çözümünü yapamaz.
- Şifrelenmiş sütunlar, veritabanı yedeklerinde de şifreli kalır. Bu, yedekleme dosyalarının kötü niyetli kişiler tarafından ele geçirilmesi durumunda bile hassas verilerin güvende kalmasını sağlar.
- AE, AES-256 gibi modern ve güçlü şifreleme algoritmalarını destekler. Bu da brute force saldırılarına karşı dirençli bir yapı sunar.

## Kurulum ve Uygulama Aşamaları  

Always Encrypted özelliğini yapılandırma ve .NET Core uygulamanızda kullanma adımlarını ayrıntılı bir şekilde öğrenmek için aşağıdaki makaleyi inceleyebilirsiniz:  

🔗 [MSSQL Veritabanı Düzeyinde Şifreleme — Always Encrypted Özelliğini Yapılandırma ve .NET Core Uygulamasında Kullanma](https://medium.com/@mustafabasdemir/mssql-veritaban%C4%B1-d%C3%BCzeyinde-%C5%9Fifreleme-always-encrypted-%C3%B6zelli%C4%9Fini-yap%C4%B1land%C4%B1rma-ve-net-fd9e35049a44)  

