// Задача 41: Введите с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

Console.Write("Введите числа через пробел: ");
int[] num = StringNum(Console.ReadLine());
int sum = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0)
    {
        sum++;
    }
} 

Console.Write($"количество введенных чисел больше нуля: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(sum);
Console.ResetColor();

int[] StringNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }

    int[] num = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ' ')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        num[index] = Convert.ToInt32(temp);
        index++;
    }
    return num;
}
