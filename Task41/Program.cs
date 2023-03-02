// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите числа:");
string numbers = Console.ReadLine();
int[] Array = GetArrayFromString(numbers);
Console.Write($" -> {PositiveNumbers(Array)}");
int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(", ");
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
int PositiveNumbers(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0) count++;
    }
    return count;
}