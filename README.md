# Comprehensive Guide to C# System Namespace and Data Structures

## 📚 Overview
The `System` namespace in C# provides the foundation of the .NET Framework, offering fundamental classes, types, utilities, and core functionality for building applications.

This guide provides an **in-depth reference** for:
- Key classes and methods in the `System` namespace.
- Core data types, collections, and utilities.
- Examples of hash tables, dictionaries, and other data structures.
- Advanced topics like threading, reflection, and serialization.

---

## 🛠️ Table of Contents
1. [Core Data Types](#core-data-types)
2. [Key Classes and Utilities](#key-classes-and-utilities)
3. [Input and Output Operations](#input-and-output-operations)
4. [Collections and Data Structures](#collections-and-data-structures)
   - [Hash Tables](#hash-tables)
   - [Dictionaries](#dictionaries)
5. [Advanced Topics](#advanced-topics)
   - [Reflection](#reflection)
   - [Threading and Tasks](#threading-and-tasks)
   - [Serialization](#serialization)
6. [System Information](#system-information)
7. [References](#references)

---

## 🔢 Core Data Types

### **Primitive Data Types**
| **Type**       | **Description**                       | **Example**              |
|-----------------|---------------------------------------|--------------------------|
| `int`          | 32-bit signed integer                 | `int x = 42;`           |
| `double`       | 64-bit floating-point number          | `double y = 3.14;`      |
| `bool`         | Boolean (`true`/`false`)              | `bool isValid = true;`  |
| `char`         | Single Unicode character              | `char letter = 'A';`    |
| `string`       | Immutable sequence of text            | `string name = "Alice";`|
| `decimal`      | High-precision floating-point         | `decimal price = 19.99m;`|

### **Nullable Types**
Nullable types allow value types to hold `null`.

```csharp
int? nullableInt = null; // Can hold null
nullableInt = 10;        // Now has a value
```

---

## 🏗️ Key Classes and Utilities

### **String Manipulation**
The `System.String` class handles text.

| **Method**           | **Description**                               | **Example**                      |
|-----------------------|-----------------------------------------------|----------------------------------|
| `ToUpper()`           | Converts to uppercase                        | `"hello".ToUpper()`             |
| `ToLower()`           | Converts to lowercase                        | `"HELLO".ToLower()`             |
| `Replace()`           | Replaces text                                | `"abc".Replace("a", "z")`       |
| `Split()`             | Splits string into an array                  | `"1,2,3".Split(',')`            |
| `Trim()`              | Removes leading/trailing whitespace          | `" hello ".Trim()`              |

#### Example:
```csharp
string message = "Hello, World!";
Console.WriteLine(message.ToUpper()); // Outputs: HELLO, WORLD!
```

---

### **Date and Time**
The `System.DateTime` and `System.TimeSpan` classes handle time and intervals.

| **Method/Property**   | **Description**                               | **Example**                      |
|------------------------|-----------------------------------------------|----------------------------------|
| `DateTime.Now`         | Current date and time                        | `DateTime.Now`                  |
| `AddDays()`            | Adds days to a date                          | `DateTime.Now.AddDays(1)`       |
| `ToString()`           | Formats date as a string                     | `DateTime.Now.ToString("yyyy")` |

#### Example:
```csharp
DateTime today = DateTime.Now;
Console.WriteLine($"Today: {today.ToShortDateString()}");
```

---

### **Mathematics**
The `System.Math` class provides mathematical utilities.

| **Method**           | **Description**           | **Example**        |
|-----------------------|---------------------------|--------------------|
| `Math.Pow()`          | Exponentiation           | `Math.Pow(2, 3)`   |
| `Math.Sqrt()`         | Square root              | `Math.Sqrt(16)`    |
| `Math.Round()`        | Rounds a value           | `Math.Round(3.75)` |

---

## 📂 Input and Output Operations

### **File Operations**
File operations are handled using `System.IO.File`.

| **Method**           | **Description**                              | **Example**                     |
|-----------------------|----------------------------------------------|----------------------------------|
| `ReadAllText()`       | Reads file content as a string               | `File.ReadAllText("file.txt")`  |
| `WriteAllText()`      | Writes a string to a file                   | `File.WriteAllText("file.txt", "Hello");` |

#### Example:
```csharp
using System.IO;

File.WriteAllText("example.txt", "Hello, World!");
string content = File.ReadAllText("example.txt");
Console.WriteLine(content); // Outputs: Hello, World!
```

---

## 🗄️ Collections and Data Structures

### **Hash Tables**
`Hashtable` is a key-value data structure from `System.Collections`.

#### Example:
```csharp
using System.Collections;

Hashtable ht = new Hashtable();
ht.Add("1", "One");
ht.Add("2", "Two");

Console.WriteLine(ht["1"]); // Outputs: One
```

### **Dictionaries**
`Dictionary<TKey, TValue>` is a generic and type-safe hash table.

#### Example:
```csharp
using System.Collections.Generic;

Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "One");
dict.Add(2, "Two");

Console.WriteLine(dict[1]); // Outputs: One
```

---

## ⚙️ Advanced Topics

### **Reflection**
Reflection allows you to inspect and manipulate types at runtime.

#### Example:
```csharp
using System;
using System.Reflection;

Type type = typeof(string);
foreach (MethodInfo method in type.GetMethods())
{
    Console.WriteLine(method.Name);
}
```

---

### **Threading and Tasks**
The `System.Threading` namespace supports multithreading.

#### Example:
```csharp
using System.Threading;

Thread thread = new Thread(() => Console.WriteLine("Running in a thread"));
thread.Start();
```

---

### **Serialization**
Serialization is converting an object into a format for storage.

#### JSON Example:
```csharp
using System.Text.Json;

string json = JsonSerializer.Serialize(new { Name = "Alice", Age = 30 });
Console.WriteLine(json); // Outputs: {"Name":"Alice","Age":30}
```

---

## 🖥️ System Information

| **Property**             | **Description**                        | **Example**                    |
|---------------------------|----------------------------------------|---------------------------------|
| `Environment.MachineName`| Gets the machine's name                | `Environment.MachineName`      |
| `Environment.OSVersion`  | Retrieves OS version                   | `Environment.OSVersion`        |
| `Environment.UserName`   | Gets the current user name             | `Environment.UserName`         |

#### Example:
```csharp
using System;

Console.WriteLine($"Machine Name: {Environment.MachineName}");
Console.WriteLine($"OS Version: {Environment.OSVersion}");
```

---

## 📖 References
- [Microsoft Docs - System Namespace](https://learn.microsoft.com/en-us/dotnet/api/system)
- [Microsoft Docs - C# Collections](https://learn.microsoft.com/en-us/dotnet/standard/collections)

---