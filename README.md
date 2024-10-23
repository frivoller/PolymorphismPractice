# README (Türkçe)
# Geometrik Şekillerin Alan Hesaplama Programı
Bu proje, kare, dikdörtgen ve dik üçgen gibi geometrik şekillerin alanlarını hesaplayan basit bir C# uygulamasıdır. Polimorfizm kullanılarak farklı şekillerin alan hesaplama işlemleri ayrı ayrı gerçekleştirilmiştir.

## Özellikler
- BaseGeometrikSekil sınıfı ile tüm şekillerin ortak özellikleri (Genislik, Yukseklik) tanımlanmıştır.
- Kare, Dikdörtgen ve Dik Üçgen sınıfları bu temel sınıftan türetilmiştir.
- Her geometrik şekil, kendi alan hesaplama yöntemini AlanHesapla metodu ile uygular.
- Kare ve Dikdörtgen için alan, Genislik x Yukseklik olarak hesaplanır.
- Dik Üçgen için alan, (Genislik x Yukseklik) / 2 formülüyle hesaplanır.

# Kullanılan Teknolojiler
- C#
- .NET Framework

# Nasıl Çalıştırılır?
- Projeyi bilgisayarınıza indirin veya kopyalayın.
- Visual Studio veya başka bir C# IDE'si ile projeyi açın.
- Projeyi çalıştırın.
- Kare, dikdörtgen ve dik üçgen için alan hesaplamalarını ekranda göreceksiniz.

# README (English)
# Geometric Shapes Area Calculation Program
This project is a simple C# application that calculates the area of geometric shapes such as square, rectangle, and right triangle. Polymorphism is used to handle different area calculations for each shape.

## Features
- The BaseGeometrikSekil class defines common properties (Width, Height) for all shapes.
- Square, Rectangle, and Right Triangle classes inherit from this base class.
- Each geometric shape implements its own area calculation using the CalculateArea method.
- Square and Rectangle calculate the area as Width x Height.
- Right Triangle calculates the area using the formula (Width x Height) / 2.

# Technologies Used
- C#
- .NET Framework

# How to Run?
- Download or clone the project to your local machine.
- Open the project in Visual Studio or any C# IDE.
- Run the project.
- You will see the area calculations for square, rectangle, and right triangle displayed on the screen.
