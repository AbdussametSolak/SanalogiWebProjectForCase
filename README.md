Solid prensiplerine de uyarak klasik katmanli mimari uzerine tasarimimi yaptim.
Veri tabani islemlerim icin Entity Framework kütüphanesinden faydalandim yaklasim olarak da database first kullandim.
Bu yuzden veritabanimi visual studyonun icerisinde bulunan sql server object ile olusturdum.

Projemizde 4 katmanimiz var.

# Entity Katmani

Burada veritabanimizda bulunan tablumuzu class olarak aciyoruz ve icerisine kolonlarimizi property olarak ekliyoruz.

# Data Acces Katmani

Adindan anlasilacagi uzere Veriye erisim katmanimiz
Crud operasyonlari icin gerekli dalimiz burada  
IOrderDal adinda bir interface
Orderdal adinda da bir class olusturdum
Direkt olarak metot imzalarini ve implemantasyonlarini yapmadim 
Birden fazla dal olabilitesi de dusunerek metot imzalarimiz icin Generic yapida interface olusturdum 
İmplemantasyonlari icin de generic yapida base class olusturdum
Dalımızın metot imzalarini generic interfaceden implemente ettim
İmplemantasyonlarini da base classtan implemente ettim

# Business Katmani 

Burada isimizi yapacak Ordermanager adinda bir classa ihtiyacımız var. Bu classımızı IOrderService den soyutladım.
IOrderService de metot ımzalarımız var.
IOrderManagerde metotlarımızı implemente ettim.
Depenedency injection ile data access katmanına gevsek bagımlılık yaptım.

# Api ve Sunum Katmani (.Net Core)

Api Controllerimde get ve post apilerimi yazdım.Swaggerda ve postmande kontrol ettıkten sonra
Sunum tarafında bu apilerime istek atıp gelen cevapları arayuzumuzde donderdım.
Sunum tarafında Html, JavaScript kullandım.
Css için de Bootstrap kutuphanesınden faydalandım.

Projeme ait gorseller ve video linki asagıdadır.
![1](https://user-images.githubusercontent.com/106724879/190357145-e0c1af77-311c-4c1f-ae30-cca316575897.png)
![2](https://user-images.githubusercontent.com/106724879/190358421-b469ac64-9fd9-4a83-b083-f3a8cef966b5.png)
