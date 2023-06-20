// ARRAY VS LIST VS ARRAYLIST //
using System.Collections;

// 1. Array (Fixed size, Strongly typed)
int[] arr = new int[2];
arr[0] = 1;
arr[1] = 2;
Array.Resize(ref arr, 3); // can do, but not preferred
arr[2] = 3;
// int[] arr2 = { 1, 2 };


// 2. List (Flexible size, Strongly typed)
List<int> list = new();
list.Add(1);
list.Add(2);


// 3. ArrayList (Flexible size, Not strongly typed)
ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add(2);
arrayList.Add("Saba"); // Boxing & UnBoxing