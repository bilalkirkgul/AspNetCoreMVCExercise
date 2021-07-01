//Dbfirst yaklaşımı ile veritabanının yanasımasını almak için package manager console ekranına 
sırasıyla aşağıdaki kütüphaneleri yüklüyoruz;

	Install-package Microsoft.EntityFrameworkCore.SqlServer
	Install-package Microsoft.EntityFrameworkCore.Tools
	Install-package Microsoft.EntityFrameworkCore.SqlServer.Design

	ardından

Scaffold-DbContext "Server=....Database=Northwind;uid=....;pwd=...." Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models