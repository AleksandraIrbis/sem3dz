//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("задача 1");
Console.WriteLine("введите пятизначное число");
string numbers=(Console.ReadLine());
if(numbers[0]==numbers[4] && numbers[1]==numbers[3]) 
{Console.WriteLine("Невероятно, это число есть палиндром!");}
else{
    Console.WriteLine("Не всегда число явдяется палиндромом. И вот сейсас как раз такой случай. Не переживайте, повезет в другой раз))");
}

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("задача 2");
Console.WriteLine("введите координаты x,y и z точки А");
string cooA=(Console.ReadLine());
Console.WriteLine("введите координаты x,y и z точки B");
string cooB=(Console.ReadLine());
double result= Math.Sqrt(Math.Pow(cooA[0]-cooB[0], 2)+ Math.Pow(cooA[1]-cooB[1], 2)+Math.Pow(cooA[2]-cooB[2], 2) );
Console.WriteLine("Расстояние между этими точками в трехмерном простарстве равно:"+ result );


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("задача 3");
Console.WriteLine("ВВедите число");
int N=Convert.ToInt32(Console.ReadLine()); 
int i=1;
Console.Write("Вывожу результаты возведения чисел от 1 до N в 3-ю степень...");
while (i<=N)
{
    
    Console.Write (Math.Pow(i,3)+ "\t"); 

    i++;

}

