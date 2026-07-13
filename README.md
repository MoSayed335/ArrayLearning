# 📚 Arrays in C# (.NET) - Complete Learning Guide

> A complete beginner-to-advanced guide to understanding Arrays in C# with practical examples.

---

# 📖 Table of Contents

- What is an Array?
- Why use Arrays?
- Array Declaration
- Array Initialization
- Access Elements
- Update Elements
- Array Length
- Loop Through Arrays
- Multi-Dimensional Arrays
- Jagged Arrays
- Array Methods
- Sorting Arrays
- Searching Arrays
- Copying Arrays
- Passing Arrays to Methods
- Returning Arrays
- Arrays vs List
- Time Complexity
- Best Practices
- Common Interview Questions
- Practice Exercises

---

# What is an Array?

An **Array** is a collection of variables that stores multiple values of the **same data type** inside one variable.

Instead of creating many variables:

```csharp
string student1 = "Ahmed";
string student2 = "Ali";
string student3 = "Omar";
```

You can write:

```csharp
string[] students = { "Ahmed", "Ali", "Omar" };
```

---

# Why use Arrays?

Arrays help you:

- Store multiple values
- Access data quickly using index
- Save memory
- Easily loop through data
- Organize related values

---

# Array Declaration

## Empty Array

```csharp
int[] numbers;
```

---

## Declare with Size

```csharp
int[] numbers = new int[5];
```

Output

```
Index: 0 1 2 3 4
Value: 0 0 0 0 0
```

---

## Declare with Values

```csharp
int[] numbers = { 10, 20, 30, 40 };
```

or

```csharp
int[] numbers = new int[]
{
    10,
    20,
    30,
    40
};
```

---

# Access Elements

Arrays use **Zero-Based Indexing**.

```csharp
string[] colors =
{
    "Red",
    "Blue",
    "Green"
};

Console.WriteLine(colors[0]);
Console.WriteLine(colors[1]);
Console.WriteLine(colors[2]);
```

Output

```
Red
Blue
Green
```

---

# Update Elements

```csharp
string[] colors =
{
    "Red",
    "Blue",
    "Green"
};

colors[1] = "Black";

Console.WriteLine(colors[1]);
```

Output

```
Black
```

---

# Array Length

```csharp
int[] numbers = { 1,2,3,4,5 };

Console.WriteLine(numbers.Length);
```

Output

```
5
```

---

# Loop Through Arrays

## for Loop

```csharp
int[] numbers = { 10,20,30 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
```

---

## foreach Loop

```csharp
foreach (var number in numbers)
{
    Console.WriteLine(number);
}
```

---

# Multi-Dimensional Arrays

Think of it as a table.

```csharp
int[,] matrix =
{
    {1,2},
    {3,4}
};

Console.WriteLine(matrix[0,0]);
Console.WriteLine(matrix[1,1]);
```

Output

```
1
4
```

---

# Jagged Arrays

Array of Arrays.

```csharp
int[][] numbers =
{
    new int[] {1,2},
    new int[] {3,4,5},
    new int[] {6}
};

Console.WriteLine(numbers[1][2]);
```

Output

```
5
```

---

# Common Array Methods

## Sort

```csharp
int[] numbers = { 4,2,8,1 };

Array.Sort(numbers);

foreach(var n in numbers)
{
    Console.WriteLine(n);
}
```

Output

```
1
2
4
8
```

---

## Reverse

```csharp
Array.Reverse(numbers);
```

---

## Clear

```csharp
Array.Clear(numbers,0,numbers.Length);
```

Result

```
0 0 0 0
```

---

## Resize

```csharp
Array.Resize(ref numbers,6);
```

---

## IndexOf

```csharp
int index = Array.IndexOf(numbers,20);
```

---

## Exists

```csharp
bool found = Array.Exists(numbers,x => x > 50);
```

---

## Find

```csharp
int value = Array.Find(numbers,x => x > 20);
```

---

## FindAll

```csharp
int[] result = Array.FindAll(numbers,x => x > 20);
```

---

## Binary Search

> Array must be sorted first.

```csharp
Array.Sort(numbers);

int index = Array.BinarySearch(numbers,30);
```

---

# Sorting Arrays

Ascending

```csharp
Array.Sort(numbers);
```

Descending

```csharp
Array.Sort(numbers);
Array.Reverse(numbers);
```

---

# Searching Arrays

Manual Search

```csharp
int target = 30;

for(int i=0;i<numbers.Length;i++)
{
    if(numbers[i]==target)
    {
        Console.WriteLine(i);
    }
}
```

Using IndexOf

```csharp
Array.IndexOf(numbers,target);
```

---

# Copy Arrays

## Copy

```csharp
int[] source = {1,2,3};

int[] destination = new int[3];

Array.Copy(source,destination,3);
```

---

## Clone

```csharp
int[] clone = (int[])source.Clone();
```

---

# Passing Arrays to Methods

```csharp
static void Print(int[] numbers)
{
    foreach(var number in numbers)
    {
        Console.WriteLine(number);
    }
}
```

Call

```csharp
Print(numbers);
```

---

# Returning Arrays

```csharp
static int[] GetNumbers()
{
    return new int[]
    {
        10,
        20,
        30
    };
}
```

---

# Arrays vs List<T>

| Feature | Array | List |
|----------|-------|------|
| Fixed Size | ✅ | ❌ |
| Dynamic Size | ❌ | ✅ |
| Faster | ✅ | Slightly Slower |
| Easy Add/Remove | ❌ | ✅ |
| Memory Efficient | ✅ | ❌ |

Use **Array** when the size is fixed.

Use **List** when the size changes frequently.

---

# Time Complexity

| Operation | Complexity |
|-----------|------------|
| Access by Index | O(1) |
| Search | O(n) |
| Binary Search | O(log n) |
| Update | O(1) |
| Insert | O(n) |
| Delete | O(n) |

---

# Best Practices

- Use meaningful variable names.
- Always check array boundaries.
- Prefer `foreach` when you don't need the index.
- Use `Array.Sort()` instead of writing your own sorting algorithm.
- Use `List<T>` if the collection size changes often.
- Avoid magic numbers; use `Length`.

---

# Common Mistakes

❌ Accessing an invalid index

```csharp
numbers[10];
```

Throws

```
IndexOutOfRangeException
```

---

❌ Forgetting Zero-Based Indexing

First element:

```csharp
numbers[0]
```

Not

```csharp
numbers[1]
```

---

# Common Interview Questions

### What is an Array?

A fixed-size collection of elements of the same type.

---

### Why are arrays faster than lists?

Arrays store elements in contiguous memory locations, making index access very fast.

---

### Difference between Array and List?

- Array → Fixed Size
- List → Dynamic Size

---

### What is a Jagged Array?

An array where each element is another array, and each inner array can have a different length.

---

### What is a Multi-Dimensional Array?

An array with more than one dimension, such as a matrix (rows and columns).

---

# Practice Exercises

- Create an array of 10 numbers.
- Find the maximum value.
- Find the minimum value.
- Reverse an array.
- Sort an array.
- Search for a specific number.
- Calculate the average.
- Count even and odd numbers.
- Merge two arrays.
- Remove duplicate values.

---

# Summary

After completing this guide, you should understand:

- ✅ Array basics
- ✅ Declaration & Initialization
- ✅ Accessing & Updating elements
- ✅ Looping through arrays
- ✅ Multi-dimensional arrays
- ✅ Jagged arrays
- ✅ Array class methods
- ✅ Sorting & Searching
- ✅ Copying arrays
- ✅ Passing arrays to methods
- ✅ Returning arrays
- ✅ Time complexity
- ✅ Best practices
- ✅ Interview questions

---

## ⭐ Support

If this repository helped you learn Arrays in C#, consider giving it a ⭐ on GitHub to support the project!
