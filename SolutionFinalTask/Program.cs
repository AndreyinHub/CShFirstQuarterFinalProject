string[] strToChange = { "hello", "2", "world", ":-)", "13" };

string[] CreateArrWithNededElemLgth(string[] array, int lgth)  //НА базе метода пузырьковой сортировки эл. массива по возрастанию
{
    int count = 0;

    for (int k = 0; k < array.Length - 1 - k; k++)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i].Length > lgth)
            {
                //count += 1;
                string temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }

        }
    }

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= lgth)
        {
            count += 1;
        }
    Console.WriteLine();

    string[] arrNew = new string[count + 1];
    arrNew[count] = Convert.ToString(count);

    for (int i = 0; i < count; i++)
    {
        arrNew[i] = array[i];
    }
    array = arrNew;

    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();
}


PrintArray(strToChange);
PrintArray(CreateArrWithNededElemLgth(strToChange, 3));
Console.WriteLine();