// Программа, которая из имеющегося массива строк формирует массив строк,
// длина которых меньше либо равна 3 символам

string[] array = new string[] { "2", ":-)", "Hello", "-2", "123", "October", "Monday" };
string[] resArray = new string[array.Length];
int j = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resArray[j] = array[i];
        j++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write(array[i] + " ");        
    }
}

PrintArray(resArray);