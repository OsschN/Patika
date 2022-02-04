//Atama ve işlemli atama
int x=3;
int y=3;
y=y+2;
Console.WriteLine(y);
y+=2;
Console.WriteLine(y);
y/=1;
Console.WriteLine(y);
x+=2;
Console.WriteLine(x);
//Mantıksal Operatörler
// ||,&&,!
bool isSucces=true;
bool isCompleted=false;
if(isSucces&&isCompleted)
Console.WriteLine("Perfect!");
if(isSucces||isCompleted)
Console.WriteLine("Great!");
if(isSucces&&isCompleted)
Console.WriteLine("Fine!");
//İlişkisel Operatörler
// <,>,<=,>=,==,!=
int a=3;
int b=4;
bool sonuc=a<b;
Console.WriteLine(sonuc);
sonuc=a>b;
Console.WriteLine(sonuc);
sonuc=a>=b;
Console.WriteLine(sonuc);
sonuc=a<=b;
Console.WriteLine(sonuc);
sonuc=a==b;
Console.WriteLine(sonuc);
sonuc=a!=b;
Console.WriteLine(sonuc);
Console.WriteLine("***** Aritmetik Operatörler *****");
// /,*,+,-
int sayı=10;
int sayı2=5;
int sonuc1=sayı/sayı2;
Console.WriteLine(sonuc1);
sonuc1=sayı*sayı2;
Console.WriteLine(sonuc1);
sonuc1=sayı+sayı2;
Console.WriteLine(sonuc1);
sonuc= sayı++ ;
Console.WriteLine(sonuc1);
// %:mod alır
int sonuc2=2043;
Console.WriteLine(sonuc2);


