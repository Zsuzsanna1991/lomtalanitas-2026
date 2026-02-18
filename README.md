# lomtalanitas-2026
Web app és API Eger város lomtalanítási utcáinak kereséséhez (ASP.NET Core + MariaDB)

Ez egy egyszerű webalkalmazás és REST API Eger város lomtalanítási utcáinak kereséséhez.  
A backend ASP.NET Core és MariaDB, a frontend egyszerű HTML/CSS/JS.

## Futattás helyben

1. Telepítsd a [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) és [MariaDB](https://mariadb.org/download/) rendszert.
2. Állítsd be az `appsettings.json` fájlban a `DefaultConnection` értékét az adatbázisodhoz.
3. Futtasd a projektet Visual Studio-ból vagy `dotnet run` parancs segítségével.
4. Nyisd meg a böngésződben az `index.html` fájlt (vagy `https://localhost:<port>`).

## API példa

- Keresés utcanévre:  
`GET /api/utcanev/search?name=Akácfa`
