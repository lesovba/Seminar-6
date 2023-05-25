
/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10*/

/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.*/

int sideA = PromptSide(); 
int sideB = PromptSide(); 
int sideC = PromptSide();


int PromptSide()
{

    Console.Write("Введите сторону треугольника: ");
    int side = int.Parse(Console.ReadLine());
    return side;
}



void CheckValidTriangle(int sideA, int sideB, int sideC)
{
    bool check = false; 
    if (sideA<(sideB+sideC) && sideB<(sideA+sideC) && sideC<(sideA+sideB))
    {check = true;}

    if (check)  
    Console.WriteLine ("Треугольник с заданными сторонами существует");
    else 
    Console.WriteLine ("Треугольника с заданными сторонами НЕ существует");

}

Console.WriteLine($"{sideA}, {sideB}, {sideC}"); 
CheckValidTriangle(sideA, sideB, sideC); 