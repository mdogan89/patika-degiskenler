// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


byte b = 5; // 1byte
sbyte sb = 5;// 1byte

short s = 5; //2byte
ushort us = 5; //2byte

Int16 i16 = 2; //2byte
int i = 2; // 4byte
Int32 i32 = 2; //4byte
Int64 i64 = 2; //8byte

uint ui = 2; //4byte
long l = 4; //8byte
ulong ul = 4;//8byte

float f = 5; //4byte
double d = 5; //8Byte
decimal de = 5; // 16byte

char c = '2'; //2byte
string str = "string"; // sınırsız

bool b1 = false;
bool b2 = true;

DateTime dt = DateTime.Now;

object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 4.5;

string str1 = string.Empty;
string str2 = "string2";
string str3 = "string3";
string str4 = str2 + " " +str3;

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 + integer2;

bool bool1 = 10<2;

string str20 = "20";
int int20 = 20;
string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger); //çıktısı 2020

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21); //çıktısı 40

int int22 = int20 + int.Parse(str20); //çıktısı 40

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);



Console.WriteLine(dt);
//Console.ReadLine();



