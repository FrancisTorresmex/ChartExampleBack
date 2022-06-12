# ChartExampleBack
Ejemplo de uso de gráficas usando Chart.js junto a EntityFramework minimal API Backend


## Notas: 📊
> Web Service creado con DataBase First, por lo que se debera ejecutar primero el archivo script `ChartExample.sql` para la creación de la base de datos y todo lo necesario.

> Cuando ya se ejecuto el script desde SQL Server, se puede pasar al paso `Conexión a base por consola`.


## Conexión a base por consola 🍻
> Si el usuario en SQL Server es de windows

PM> `Scaffold-DBContext "Server=localhost;Database=ChartExample;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models`

> Si la cuenta es otra

PM> `Scaffold-DBContext "Server=localhost;Database=ChartExample;User=sa;Password=contraseña;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models`

> Nuevos elementos como tablas(Opcional)

PM> `Scaffold-DBContext "Server=localhost;DataBase=ChartExample;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force`

> El  `-outputDir` es porque sin el se genera en la raiz del proyecto y en este caso se queria generar en la carpeta llamada Models del proyecto.

