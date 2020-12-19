# Searching

## Linear Search

### Linear Search description
This algorithm goes 1 by 1 in order through an array and finds whatever value you are looking for

### Linear Search best case and worst case
best case: O(1)  
worst case: O(n)

### Linear Search pseudocode
i = 0  
if array[i] = target  
{  
  return i   
}  
else  
{  
  i++  
}  
return failed search

## Binary Search

## Binary Search description
This algorithm only works with a sorted array and works by starting with the middle number in the array. If the middle number is our number we end there.
If our target is greater than the middle number we change the range to only look at the greater half of the array, or we look at the lower half of the array if the target is lesser than the middle.
Then we repeat this process until the middle is the same as our target.

### Binary Search best case and worst case
best case: O(1)
worst case: O(log n)
