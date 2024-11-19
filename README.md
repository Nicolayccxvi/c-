# Notes on C# System Library and Hash Tables

## 📚 System Library Overview
The `System` namespace in C# provides fundamental classes and base functionality for applications, including types, file I/O, math functions, threading, and more.

### **Core Features of the `System` Namespace**

#### **1. Primitive Types and Conversion**
- Basic data types: `Int32`, `Double`, `Boolean`, etc.
- Conversion: `Convert` class for type conversion.
- Math operations: `Math.Abs`, `Math.Pow`, `Math.Sqrt`, `Math.Sin`, etc.
- Random numbers: `Random` for generating random values.

#### **2. Text Manipulation**
- `String` class for text operations (`Replace`, `ToUpper`, `ToLower`).
- `StringBuilder` for efficient text modification.
- `Char` for working with individual characters.

#### **3. Date and Time**
- `DateTime`: Current date/time (`DateTime.Now`, `AddDays`, `ToString`).
- `TimeSpan`: Represents time intervals.
- `DateTimeOffset`: Includes timezone information.

#### **4. File and Directory Management**
- `System.IO.File`: File operations (read, write, delete).
- `System.IO.Directory`: Manage directories.
- `System.IO.Path`: Handle file paths.

#### **5. System Information**
- `Environment`: Access environment variables, OS info, and user data.
- `GC`: Manage garbage collection.

#### **6. Exception Handling**
- `System.Exception`: Base class for error handling.
- Common exceptions: `ArgumentException`, `NullReferenceException`, `IOException`.

---

## 🗄️ Hash Tables and Dictionaries in C#

### **1. Hashtable (Non-Generic)**
The `Hashtable` class is a key-value pair data structure found in the `System.Collections` namespace.

```csharp
using System.Collections;

Hashtable ht = new Hashtable();
ht.Add("1", "One");
ht.Add("2", "Two");
ht.Add("3", "Three");

if (ht.ContainsKey("2")) 
{
    Console.WriteLine("Key 2 exists.");
}

foreach (DictionaryEntry entry in ht) 
{
    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
}
