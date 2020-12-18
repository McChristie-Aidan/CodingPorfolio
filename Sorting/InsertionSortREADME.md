# Insertion Sort
## InsertionSort description:
insertions sort pulls out each item and goes through each previously sorted item one by one to find its place. It reminds me of flipping through a book page by page.
## InsertionSort best case and worst case
O(n) and O(n^2)
## InsertionSort pseudocode
i = 1\
while i < Length(array)\
j = i\
while j > 0 and array[j-i] > array[j]\
swap array[j] and array[j-1]\
j = j-1\
end while
i = i+1
end while
