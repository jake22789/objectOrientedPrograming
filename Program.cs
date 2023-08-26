// See https://aka.ms/new-console-template for more information
using System.Globalization;

void SelectionSort(int[] values)
{
    for (int i = 0; i<5;i++)
    {
        Console.WriteLine(values[i]);
    }
    Console.WriteLine("sort");
    int hold = 0;
    int indi = 0;
    for(int J=1;J<values.Length;J++)
    {
        for (int i = 0; i<(values.Length-J); i++)
        {
            if (values[i]>hold)
            {
                hold = values[i];
                indi = i;
            }
        }
        if(hold > values[values.Length-J])
        {
            values[indi] = values[values.Length-J];
            values[values.Length-J] = hold;
            hold=0;
        }
    }
    for (int i = 0; i<5;i++)
    {
    Console.WriteLine(values[i]);
    }
}


int[] n = {8 , 10, 3, 5, 1};
SelectionSort(n);