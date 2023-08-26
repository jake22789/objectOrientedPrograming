// See https://aka.ms/new-console-template for more information
void SelectionSort(int[] values){
    int hold = 0;
    int indi = 0;
    
    for (int i = 0; i<(values.Length-1); i++){
        if (values[i]>hold){
            hold = values[i];
            indi = i;
            Console.Write("new high");
        }
    }
    values[indi] = values[values.Length-1];
    values[values.Length-1] = hold;
    
    for (int i = 0; i<5;i++){
    Console.WriteLine(values[i]);
}
}


int[] n = {5 , 4, 6, 2, 1};
for (int i = 0; i<5;i++){
    Console.WriteLine(n[i]);
}
Console.WriteLine("sort");
SelectionSort(n);

    
