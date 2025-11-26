# C# Fundamentals — Lesson & Practice Assignments

## Overview
This document is a compact but comprehensive lesson covering C# fundamentals, common libraries (collections, LINQ), tooling, and idiomatic patterns. It is designed for beginners and for developers who want a refresher.

> Note: This lesson is descriptive and includes practice assignments. No source code is modified in your workspace.

---

## Table of Contents
- Introduction
- Setup & Tooling
- Syntax & Project Structure
- Types & Variables
- Operators & Expressions
- Control Flow
- Methods & Parameters
- Classes, Structs & Records
- Inheritance, Interfaces & Polymorphism
- Generics & Collections
- LINQ (Query & Method Syntax)
- Delegates, Lambdas & Events
- Exception Handling
- Async & Concurrency
- File I/O & Serialization
# C# Fundamentals — Lesson & Practice Lessons

## Overview
This document provides a compact, practical lesson plan and a sequence of hands-on practice lessons. Each practice lesson corresponds to a numbered C# source file you can create in the workspace (starting from `2_...`).

Note: I will not modify your existing C# code. The lesson below describes per-file practice lessons and includes what you'll learn, how to use the file as a lesson, and the practice assignment for each.

---

## Table of Contents
- Introduction
- How to organize practice files
- Per-lesson practice entries (2 -> ...)
- Bigger applied projects
- Study tips & progression

---

## Introduction
C# is a modern, statically-typed, object-oriented language running on the cross-platform .NET runtime. This document maps theory to concrete practice files so you can work lesson-by-lesson.

## How to organize practice files
- Naming convention: `N_Description.cs` where `N` is the lesson number. You already have `1_Input_Output_MathOperation.cs`.
- Create the next files as you go: `2_ConditionalStatement.cs`, `3_Loops.cs`, `4_Methods.cs`, etc.
- Each file is a self-contained console program or small module demonstrating the lesson topic.
- For each practice file below I include:
   - What you'll learn
   - Usage (how to run or integrate it)
   - Practice assignment (what to implement; no code included)

---

## Practice Lessons (per-file)

2_ConditionalStatement.cs
- What you'll learn: `if/else`, `else if`, ternary operator, `switch` statement and `switch` expressions, basic input validation.
- Usage: Implement as a console app that reads a value and branches behavior; test several inputs.
- Practice assignment: Create a program that asks for a numeric score (0–100) and prints the letter grade (A/B/C/D/F) using a `switch` expression or `if/else` ladder. Re-prompt on invalid input.

3_Loops.cs
- What you'll learn: `for`, `foreach`, `while`, `do-while`, `break`, `continue`, and enumerating collections/arrays.
- Usage: Write small console routines in the file that demonstrate each loop type.
- Practice assignment: Implement a simple menu that lets a user add numbers to a list, display them, compute sum/average, and exit. Use `while` or `do-while` for the menu loop and `foreach` for display.

4_Methods.cs
- What you'll learn: method declaration, return types, `void`, `ref`/`out` parameters, `params`, optional/default parameters, local functions, and expression-bodied methods.
- Usage: Factor logic from earlier lessons into reusable methods in this file.
- Practice assignment: Create a utility library in the file with methods `ParseInt(string)`, `CalculateAverage(IEnumerable<int>)`, and `FormatCurrency(decimal)`. Write a small interactive demo that uses these methods.

5_Classes_And_Structs.cs
- What you'll learn: defining classes and structs, constructors, properties (auto and full), read-only fields, `ToString()` overrides.
- Usage: Model small domain objects and create instances in a `Main` method.
- Practice assignment: Define `Person` (Name, Age, Height) as a `class` and `Point` (X, Y) as a `struct`. Instantiate multiple `Person` objects and print them.

6_OOP_Inheritance_Polymorphism.cs
- What you'll learn: base/derived classes, `virtual`/`override`, abstract classes, implementing interfaces, Liskov substitutability.
- Usage: Build an inheritance hierarchy and demonstrate polymorphic method calls.
- Practice assignment: Create an abstract `Animal` with `Speak()` and derived `Dog`/`Cat` classes. Write a method that accepts `IEnumerable<Animal>` and calls `Speak()` on each.

7_Generics_Collections.cs
- What you'll learn: generics definition and usage, `List<T>`, `Dictionary<TKey, TValue>`, `HashSet<T>`, queues/stacks, `IEnumerable<T>` vs `ICollection<T>`.
- Usage: Manipulate collections and show common operations (add/remove/find).
- Practice assignment: Build a simple contact list using `Dictionary<string, Contact>` keyed by email or ID; implement add, remove, find, and list operations.

8_LINQ.cs
- What you'll learn: LINQ query syntax and method syntax, deferred execution, projections, grouping, joining, ordering, aggregation.
- Usage: Use LINQ to query lists created in earlier lessons.
- Practice assignment: Given a collection of `Person` objects, write LINQ queries to: filter adults (18+), group by age range, select top 3 tallest, and compute average height per age group.

9_Delegates_Events_Lambdas.cs
- What you'll learn: delegates, `Func`/`Action`/`Predicate`, lambda expressions, closures, defining and raising events, subscribing/unsubscribing.
- Usage: Create a small publisher and multiple subscribers that react to events.
- Practice assignment: Implement a `TimerPublisher` that raises a `Tick` event every second and a subscriber that logs ticks; also show a lambda subscription that counts ticks.

10_Exceptions_And_Using.cs
- What you'll learn: `try/catch/finally`, custom exceptions, argument validation, `using` and `IDisposable`, exception best practices.
- Usage: Add robust error handling to earlier practice files, demonstrate resource cleanup.
- Practice assignment: Wrap file reading and parsing operations in exception handlers; create a custom `InvalidDataException` and throw it for malformed input.

11_Async_Await.cs
- What you'll learn: `Task`/`Task<T>`, `async`/`await`, `Task.WhenAll`, cancellation with `CancellationToken`, avoiding deadlocks.
- Usage: Create asynchronous methods that simulate I/O (e.g., `Task.Delay`) and compose them.
- Practice assignment: Write an async method that fetches simulated data from 3 endpoints concurrently, aggregates results, and supports cancellation.

12_FileIO_Serialization.cs
- What you'll learn: `System.IO` APIs (`File`, `FileStream`, `StreamReader/Writer`), `System.Text.Json` for serialization/deserialization, safe path handling.
- Usage: Persist objects from earlier lessons (contacts, students) to JSON files and load them back.
- Practice assignment: Implement saving and loading of the contact list in `7_Generics_Collections.cs` to a JSON file; include basic schema validation.

13_Reflection_Attributes.cs
- What you'll learn: `Type` inspection, `GetProperties()`/`GetMethods()`, custom attributes, reading attribute data, and basic scenarios for runtime mapping.
- Usage: Define a custom attribute (e.g., `[CsvColumn]`) and use reflection to map CSV columns to properties.
- Practice assignment: Create `[CsvColumn(Name)]` and describe how to use reflection to populate objects from a CSV row (implement parsing logic as an extra challenge).

14_UnitTests.cs
- What you'll learn: writing unit tests with xUnit (or NUnit/MSTest), test fixtures, assertions, mocking principles.
- Usage: Create a test project, add tests for pure logic (calculation functions, parsing), run `dotnet test`.
- Practice assignment: Write unit tests for calculator functions, grade calculation, and contact repository operations.

---

## Bigger Applied Projects (combine multiple lessons)
These are larger assignments that apply many lessons together. They are open-ended; implement incrementally.

- Project A — Contacts & Task Manager (console)
   - Combine: classes, collections, file I/O, serialization, LINQ, async (for background autosave), and unit tests.
   - Features: Add/edit/delete contacts/tasks, search/filter with LINQ, persist to JSON, and unit tests for core logic.

- Project B — Inventory & Orders (mini e-commerce backend)
   - Combine: OOP modeling, generics repository, LINQ queries (reports), exceptions, async operations for order processing, and unit tests.
   - Features: CRUD for products, inventory check, place orders (decrease stock), generate sales reports.

- Project C — Task Tracker Web API (minimal)
   - Combine: layering, dependency injection, async file/DB access, LINQ for queries, unit tests for services.
   - Tech: Use `dotnet new webapi` (optional): implement simple REST endpoints for tasks and a JSON file or in-memory repository for persistence.

---

## Study Tips & Suggested Progression
1. Work file-by-file: implement `2_ConditionalStatement.cs` then `3_Loops.cs`, etc. Keep each file focused on its topic.
2. After finishing core lessons (1–8), take the LINQ and async lessons and add tests.
3. Attempt one bigger applied project (A or B) to combine skills.
4. Use Git and commit frequently — one commit per lesson or feature.

---

