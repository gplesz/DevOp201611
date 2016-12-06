# DevOp201611
A NetAcademia DevOp tanfolyamának kódtár kiegészítése

## Előkészületek
A tanfolyam zökkenőmentes elvégzéséhez a következő előkészületekre van szükség

### VMWare player telepítése
A használathoz a VMWare ingyenes Player kell, amit [innen lehet letölteni](http://www.vmware.com/products/player/playerpro-evaluation.html)

A VMWare Windows 10-re telepítéséhez lehet, hogy  [le kell tiltani a Credential Guard/Device Guard](https://kb.vmware.com/selfservice/microsites/search.do?language=en_US&cmd=displayKC&externalId=2146361) nevű szolgáltatást. Részletes leírás a linken.

### Windows virtuális gépek
Windows virtuális gépekre lesz szükségünk, amihez az alapot [innen lehet letölteni](https://vidibitstorage.blob.core.windows.net/elsfree/w2k12r2-1.rar):

Letöltés után csomagoljuk ki, és másoljuk le háromszor, ezekre fogjuk telepíteni a build szerverünkről az SQL szervert, a WebAPI-t és a Webes alkalmazásunkat. A gépekre a bejelentkezési név: **Administrator** a jelszó: **Windows2012**

### Azure regisztráció
Az [Azure kezdőlapon](https://azure.microsoft.com/hu-hu/) lehet a regisztrációt kezdeményezni a **Kezdetben ingyenes** gombbal. Kell hozzá egy Microsoft-fiók, egy telefonszám és egy (VISA/Mastercard/AmericanExpress) bankkártya. A regisztráció ingyenes, és az első 30 napban 170 EUR keretet ad, ezt fogjuk felhasználni a tanfolyamon. Az ingyenességről [itt lehet részletesen olvasni](https://azure.microsoft.com/hu-hu/free/free-account-faq/).

### visualstudio.com regisztráció
A [Visual Studio kezdőoldalán](https://www.visualstudio.com/) a középső oszlopban lévő Visual Studio Team Services alatt a **Get started for free** feliratnál lehet kezdeményezni. Az előző lépésben használt Microsoft-fiók kell hozzá.

### Chocolatey telepítése
[Csomagkezelőt](http://netacademia.blog.hu/2016/11/03/hogyan_keszitsunk_chocolatey_csomagot_az_alkalmazasunkhoz) telepítünk: [chocolatey.org](https://chocolatey.org/)

Telepítéshez ezt másoljuk a vágólapra az oldalról: 

**@powershell -NoProfile -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"**

majd bemásoljuk egy adminisztrátori parancssorba, és lefuttatjuk.

(ld. [ElasticSearch dióhéjban tanfolyam](http://netacademia.hu/ELSfree-elastic-search--nutshell), előkészületek fejezetben, kb a 12. perctől)

### Visual Studio 2015 Community telepítése
Adminisztrátori parancssorból: **cinst visualstudio2015community** (nagyjából 35 perc)

### SQL Server 2016 Express telepítése
Adminisztrátori parancssorból: **cinst sql-server-express** (nagyjából 10 perc)

### SQL Server management Studio telepítése
Adminisztrátori parancssorból: **cinst sql-server-management-studio** (nagyjából 15 perc)

### Az ElasticSearch 
Korábban tartottunk egy [Elasticsearch ingyenes alkalmat](http://netacademia.hu/ELSfree-elastic-search--nutshell), ahol négy órában telepítettük az ElasticSearch csomag elemeit és a RabbitMQ üzenetszolgáltatást. Érdemes áttekinteni, mert annak a tanfolyamnak az eredményeit felhasználva indulunk neki az események begyűjtésének.

A tanfolyam végeredményét innen lehet letölteni: [Windows Server 1 (ELK)](https://vidibitstorage.blob.core.windows.net/elsfree/w2k12r2-elk.rar) és [Windows Server 2 (APP)](https://vidibitstorage.blob.core.windows.net/elsfree/w2k12r2-app.rar), mindkét gépre a bejelentkezési név: **Administrator** a jelszó: **Windows2012**
