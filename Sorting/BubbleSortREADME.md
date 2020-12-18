#Bubble Sort\
##BubbleSort Description:\
BubbleSort looks at the first pair and swaps them if the first item is bigger than the second. it then moves the focus 1 item to the right and continues the sort.\

##BubbleSort best case worst case:\
O(n^2) and O(n^2)\

##BubbleSort Pseudocode:\
Bubblesort(Data: values[])\
    //Repeat until the array is sorted.\
    Boolean: not_sorted = True\
    While (not_sorted)\
        // Assume we won't find a pair to swap.\
        not_sorted = False\
        // Search the array for adjacent items that are out of order.\
        For i = 0 To <length of values> - 1\

//See if items i and i - 1 are out of order.\
            If (values[i] < values[i - 1]) Then\
                // Swap them.\
                Data: temp = values[i]\
                values[i] = values[i - 1]\
                values[i - 1] = temp\
 
                // The array isn't sorted after all.\
                not_sorted = True\
            End If\
        Next i\
    End While\
End Bubblesort  \
