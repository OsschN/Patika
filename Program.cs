byte b=5; //1byte
sbyte c=5; //1byte
short s=5; //2byte
ushort us=5; //2byte
Int16 i16=2; //2byte
int i =2; //4byte
int32 i32=2; //4byte
int64 i64=2; //8byte
uint ui=2; //4byte
long l =4; //8byte
ulong ul=4; //8byte
//reel sayılar
float f=5; //4byte
double d=5; //8byte
decimal de=5; //16byte
char ch ='2'; //2byte
string str="Zikriye"; //sınırsız
bool b1=true;
bool b2=false;
Datetime dt =Datetime.now;
Console.Writeline("dt");
object o1="x";
object o2='y';
object o3=4;
object o4=4.3;
//string ifadeler
string str1 =string.Empty;
str1="Zikriye Ürkmez";
string ad="Zikriye";
string soyad="Ürkmez";
string tamisim=ad+" "+ soyad;
//integer tanım sekilleri
int integer1=5;
int integer2=3;
int integer3=integer1+integer2;
//boolean
bool bool1=10>2;
//degisken dönüşümleri
string str20="20";
int int20=20;
string yenideger=str20+int20.ToString();
Console.WriteLine(yenideger); //Çıktısı2020
int int21=int20+convert.toınt32(str20);
console.Writeline(int21); //cıktısı40
int int22=int20+int20+int.Parse(str20); //cıktısı40
//datetime
string datetime =datetime.now.ToString("dd.MM.yyyy");
console.Writeline(datetime);
string datetim2=Datetime.now.ToString("dd/MM/yyyy");
console.Writeline(datetime2);
string hour =datetime.now.ToString("dd/MM/yyyy");
console.Writeline(datetime2);

