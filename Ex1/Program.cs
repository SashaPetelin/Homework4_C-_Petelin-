Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, обозначающее степень, в которую нужно возвести число А: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("Число А в степени В равно: ");
Console.WriteLine(GetDegree(A, B));

int GetDegree(int A, int B)
{
int i = 0;
int temp = 1;
while (i<B)
{
    temp=temp*A; 
    i++; 
}
return temp;
}