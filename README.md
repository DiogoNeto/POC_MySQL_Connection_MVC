# POC_MySQL_Connection_MVC
Database configurations:

tcp/id port: 3306 x protocol port 33060
alter user 'root'@'localhost' identified by 'root';
Scaffold-Db-Context "server=localhost;port=3306;user=root;password=root;databse=novocuidar" MySql.Data.EntityFramework -OutputDir DataObjects -f
server=localhost;initial catalog=NOVO_CUIDAR_APP; uid=root;pwd=root; Microsoft.EntityFrameworkCore.ServiceVersion.Parse("8.0.36-mysql")))

Microsoft.EntityFrameworkcore.design
Add-Migration Criacao_Inicial -Context Contexto
