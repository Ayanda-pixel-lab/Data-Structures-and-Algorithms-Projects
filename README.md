# Selection Sorting Project
Student Management System (C#)

Project Overview
A Computer Science foundational project of a C# Console application  designed to demonstrate the Selecion Sort Algorithm logic as well as the "List" Data Structure. It is a clear demonstration of my understanding in implementing data structures, sorting logic and managing lists and arrays to create a user friendly CLI.
-The system is designed to manage student profiles, student full names and student number.
-It starts with a number of 30 unsorted predeclared complete student profiles.
-It uses then uses the user interactive menu to add and remove a desired number of students in real-time.
-Data integrity is ensured by the automatic resorting of student numbers that takes place everytime modification happens.

Key Features
- Pre-loaded list dataset: There are intially 30 student profiles that are not yet sorted for a quick testing in the system.
- An interactive CLI menu: Prompts a user to add or remove profiles.
- Preservation: The students IDsand full names are accurately linked together.
- Auto Sorting: A selection sort algorithm is automatically triggered when modification happens to maintain the student number numerical order.

WorkFlow
1. Initial Sorting: The system executes a selection sort pass to sort the initial 30 base students loaded in memory by student number.
2. User input: After the user views the initial sorted list, the system asks if they would like to add or remove any student.

Data Modification
1. If Add: The system asks how many students the user wants to add then collects all the data, student full name and student number,appends it and the new list is updated and reorded by the selection sort algorithm.
2. If Remove:  The system asks how many students the user wants to remove then asks for a student number, it loops through the list to find the matching student number. If found the student is removed and if not the user is informed. The lists is updated.

Display
1. The fully updated profile list is displayed for the user in the terminal screen.

Principles and Technical skills
- Language: C# (.NET 8.0)
- Data Handling: Object management using List<T> / arrays.
- Algorithmic Logic: Selection sort algorithm implementation with a time complexity of O(n²)
- Control Flow: Conditional if-else statements, for loops anf foreach statements for menu handling and validating input.
