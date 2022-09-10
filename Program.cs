// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void palindrom (int a){
    string num = a.ToString();
    int n = num.Length;
 if (num[0]== num[4] && num [1] == num [3]) {
    Console.WriteLine("Введенное число палиндром");
    }
    
    else {
        Console.WriteLine("Введенное число не палиндром");
    }
}
Console.WriteLine("Введите пятизначное число :");
int x = Convert.ToInt32(Console.ReadLine());
if (x <9999 || x >99999) {
    Console.WriteLine ("Вы ввели не коректное число");
}
else palindrom(x);
*/

//Напишите программу, 
//которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

double Dist (int x1, int y1, int z1, int x2, int y2, int z2) {
    int min1 = x2 - x1;
    int min2 = y2 - y1;
    int min3 = z2 - z1;
    int squaer1 = min1*min1;
    int squaer2 = min2*min2;
    int squaer3 = min3*min3;
    double distance = Math.Sqrt(squaer1+squaer2+squaer3);
    return distance;
}
Console.WriteLine("Введите x1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2: ");
int c2 = Convert.ToInt32(Console.ReadLine());
double res = Dist (a1,b1,c1,a2,b2,c2);
Console.WriteLine(res);