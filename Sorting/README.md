# Bubble Sort
## Bubble Sort Description:
BubbleSort looks at the first pair and swaps them if the first item is bigger than the second. it then moves the focus 1 item to the right and continues the sort.\

## Bubble Sort best case worst case:
O(n^2) and O(n^2)\

## Bubble Sort Pseudocode:
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
                values[i - 1] = temp  
                // The array isn't sorted after all.  
                not_sorted = True\
            End If\
        Next i\
    End While\
End Bubblesort  \

# Insertion Sort
## Insertion Sort description:
Insertions sort pulls out each item and goes through each previously sorted item one by one to find its place. It reminds me of flipping through a book page by page.

## Insertion Sort best case and worst case
O(n) and O(n^2)

## Insertion Sort pseudocode
i = 1\
while i < Length(array)\
j = i\
while j > 0 and array[j-i] > array[j]\
swap array[j] and array[j-1]\
j = j-1\
end while
i = i+1
end while

# Selection Sort
## Selection Sort description:
Slection Sort walks through the whole array for every item and tries to find the smallest values in the array. Then it swaps whatever it finds (if anything) 
with the currently selected item in the array.

## Selection Sort best case and worst case
O(n^2) and O(n^2)

## Selection Sort pseudocode
Selectionsort(Data: values[])\
    For i = 0 To <length of values> - 1\
        // Find the item that belongs in position i.\
        <Find the smallest item with index j >= i.>\
        <Swap values[i] and values[j].>\
    Next i\
End Selectionsort  \



