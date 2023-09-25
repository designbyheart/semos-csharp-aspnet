using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS.Models {
  public static class Repo {
    static string amazonISBN(string isbn) {
      isbn = isbn.Replace("-", "");
      return isbn.Length != 13 ? isbn : isbn.Insert(3, "-");
    }
    static Repo() {
      Exams.Clear();
      Books.ForEach(b =>
        b.Download = b.Purchase ?? (b.Purchase
                                ?? ((b.ISBN != null && b.ISBN != "") ? "https://www.amazon.com/s?k=" + amazonISBN(b.ISBN) : null)));
    }

    static public Dictionary<string, Course> Courses = new Dictionary<string, Course>() {
      {"MOC20483", new Course("MOC20483","Programming in C#",
          new Module("Review of Visual C# Syntax",
            "Overview of Writing Application by Using Visual C#",
            "Data Types, Operators, and Expressions",
            "Visual C# Programming Language Constructs"
          ),
          new Module("Creating Methods, Handling Exceptions, and Monitoring Applications",
            "Creating and Invoking Methods",
            "Creating Overloaded Methods and Using Optional and Output Parameters",
            "Handling Exceptions"
          ),
          new Module("Basic types and constructs of Visual C#",
            "Implementing Structs and Enums",
            "Organizing Data into Collections",
            "Handling Events"
          ),
          new Module("Creating Classes and Implementing Type-Safe Collections",
            "Creating Classes",
            "Defining and Implementing Interfaces",
            "Implementing Type-Safe Collections"
          ),
          new Module("Creating a Class Hierarchy by Using Inheritance",
            "Creating Class Hierarchies",
            "Extending .NET Framework Classes"
          ),
          new Module("Reading and Writing Local Data",
            "Reading and Writing Files",
            "Serializing and Deserializing Data",
            "Performing I/O by Using Streams"
          ),
          new Module("Accessing a Database",
            "Creating and Using Entity Data Models",
            "Querying Data by Using LINQ"
          ),
          new Module("Accessing Remote Data",
            "Accessing Data Across the Web",
            "Accessing Data by Using OData Connected Services"
          ),
          new Module("Designing the User Interface for a Graphical Application",
            "Using XAML to Design a User Interface",
            "Binding Controls to Data"
          ),
          new Module("Improving Application Performance and Responsiveness",
            "Implementing Multitasking",
            "Performing Operations Asynchronously",
            "Synchronizing Concurrent Access to Data"
          ),
          new Module("Integrating with Unmanaged Code",
            "Creating and Using Dynamic Objects",
            "Managing the Lifetime of Objects and Controlling Unmanaged Resources"
          ),
          new Module("Creating Reusable Types and Assemblies",
            "Examining Object Metadata",
            "Creating and Using Custom Attributes",
            "Generating Managed Code",
            "Versioning, Signing, and Deploying Assemblies"
          ),
          new Module("Encrypting and Decrypting Data",
            "Implementing Symmetric Encryption",
            "Implementing Asymmetric Encryption"
          )
        )
      },
      {"SE001CS", new Course("SE001CS","Introduction to C#",
          new Module("Introduction",
            "What is .NET?",
            "The IDE",
            "Simple C# example",
            "What can we do with C#?",
            "Debugging C#"
          ),
          new Module("Flow Control",
            "Sequential",
            "Branching",
            "Iteration"
          ),
          new Module("Basic Types",
            "Reference Types",
            "Value Types",
            "Simple Data Types",
            "String",
            "Enums",
            "Constants"
          ),
          new Module("Operators",
            "Arithmetic Operators",
            "Comparison Operators",
            "Logical Operators",
            "Bitwise Operators",
            "Special Operators",
            "Degree, Association and Precedence"
          ),
          new Module("Classes and Objects",
            "Objects and Classes",
            "Encapsulation",
            "Inheritance",
            "Constructors and Destructors",
            "Constructor Chaining",
            "Reference Types: Objects and Variables",
            "Class Members",
            "Namespaces"
          ),
          new Module("Access Modifiers",
            "Information Hiding",
            "public",
            "protected",
            "private",
            "internal",
            "protected internal"
          ),
          new Module("Methods, Fields and Properties",
            "Methods",
            "Fields",
            "Properties",
            "Method Overloading"
          ),
          new Module("Parameters",
            "Passing by Value",
            "Passing by Reference",
            "Passing by Out",
            "Default parameter value",
            "Param Array",
            "Named Arguments"
          ),
          new Module("Array",
            "Single Dimensional Array",
            "Multi-Dimensional Array",
            "Array of Array",
            "Jagged Array"
          ),
          new Module("Useful Collections",
            "ArrayList",
            "Generic List",
            "Dictionary"
          ),
          new Module("Errors and Exception Handling",
            "Fault, Error, and Failure",
            "Different types of Error",
            "What is Exception?",
            "Why need to handle exceptions?",
            "Try-catch block",
            "System level Exception Hierarchy",
            "Multiple catch blocks and the rule",
            "The finally block",
            "Re-throw technique",
            "Custom Exceptions"
          ),
          new Module("Delegates and Events",
            "Single Cast delegates",
            "Multicast Delegates",
            "Events"
          )
        )
      },
      {"SE005CS", new Course("SE005CS","High Performance C#",
          new Module("Why High Performance is needed?",
            "Some scenarios",
            "Factors affecting performance in C# programming",
            "The Benchmarking preparation"
          ),
          new Module("Language Constructs",
            "Conventional for Vs foreach",
            "IEnumerable, yield return and foreach",
            "Row-First Vs Column-First iteration",
            "The impact of Recursion",
            "The impact of constructor chaining",
            "Remove Redundant Code"
          ),
          new Module("Operators",
            "Leverage on short circuit",
            "The impact of boxing and unboxing",
            "==, Equals and ReferenceEquals",
            "Using bitwise operators"
          ),
          new Module("Parameters",
            "Optional parameter Vs method overloading",
            "Parameter passing By Value Vs By Reference",
            "Normal return Vs return by out"
          ),
          new Module("Collections and Foundation Classes",
            "Using StringBuilder",
            "Generic List initial internal buffer size",
            "Using Dictionary",
            "Using proper collections"
          ),
          new Module("Special Methods",
            "Using String.Compare method",
            "Using Array.Copy",
            "Using TryParse() method",
            "Using Buffer.BlockCopy"
          ),
          new Module("C# Specific",
            "struct Vs class",
            "getter Vs readonly field",
            "The impact of overflow check",
            "Extension Method",
            "The impact of inlining",
            "Using class level members"
          ),
          new Module("C# Advanced Features",
            "Using cloning",
            "Using pointer",
            "Asynchronous coding",
            "Meta coding"
          ),
          new Module("Other Techniques",
            "Avoid costly functions",
            "Refactor to less costly expression",
            "Lookup Tables",
            "Caching"
          ),
          new Module("Using Patterns",
            "FlyWeight",
            "Prototype"
          )
        )
      },
      {"SE012CS", new Course("SE012CS","Defensive Programming in C#",
          new Module("Introduction",
            "What is Defensive Programming?",
            "Clean Code",
            "Testable Code and Unit Tests",
            "Predictable Code"
          ),
          new Module("Defending Your Methods - Part 1",
            "Clean, Testable, and Predictable Methods",
            "Example Clean, Testable, and Predictable Methods",
            "Demo Creating a Class Library Component",
            "Demo Clean, Testable, and Predictable Methods",
            "Demo Named Arguments"
          ),
          new Module("Defending Your Methods - Part 2",
            "Validating Method Parameters",
            "Demo Validating Method Parameters",
            "Demo Method Overloading"
          ),
          new Module("Automated Code Testing",
            "Why automated testing?",
            "Code First vs. Test First",
            "Defining Unit Test Cases",
            "Creating Unit Tests",
            "Using Test Explorer",
            "Generating Unit Tests",
            "Unit Tests and Exceptions",
            "Dependencies"
          ),
          new Module("Returning Predictable Results",
            "Method Results",
            "Demo Returning a Value",
            "Demo Returning Exceptions",
            "Demo Returning Multiple Values",
            "Returning Null"
          ),
          new Module("Defending Your Code Constructs",
            "Local Variable Declarations",
            "If Statements",
            "Switch Statements",
            "Enums",
            "Casting"
          ),
          new Module("Asserts, Errors, and Exceptions",
            "Demo Preparing the Sample Code",
            "Asserts",
            "Anticipated Errors",
            "Unexpected Exceptions and a Global Exception Handler",
            "Exception Handling"
          ),
          new Module("Design by Contract",
            "Introduction",
            "Tolerant Vs Demanding coding styles",
            "Pre-Conditions",
            "Post-Conditions",
            "Class Invariant",
            "Loop Invariant"
          ),
          new Module("Case Study",
            "8-Puzzle"
          )
        )
      },
      {"SE013CS", new Course("SE013CS","Refactoring to Patterns using C#",
          new Module("Introduction",
            "The Patterns Panacea",
            "Under-Engineering",
            "Test-Driven Development and Continuous Refactoring",
            "Refactoring and Patterns",
            "Evolutionary Design"
          ),
          new Module("Refactoring",
            "What Is Refactoring?",
            "The motivations to refactor",
            "Human-Readable Code",
            "Keeping It Clean",
            "Small Steps",
            "Design Debt",
            "Evolving a New Architecture",
            "Composite and Test-Driven Refactorings",
            "The Benefits of Composite Refactorings",
            "Refactoring Tools"
          ),
          new Module("Patterns",
            "What Is a Pattern?",
            "Very brief introduction to the GoF Patterns",
            "There Are Many Ways to Implement a Pattern",
            "Refactoring to, towards, and away from Patterns",
            "Do Patterns Make Code More Complex?",
            "Pattern Knowledge",
            "Up-Front Design with Patterns"
          ),
          new Module("The Indicators",
            "Duplicated Code",
            "Long Method",
            "Conditional Complexity",
            "Primitive Obsession",
            "Indecent Exposure",
            "Solution Sprawl",
            "Alternative Classes with Different Interfaces",
            "Lazy Class",
            "Large Class",
            "Switch Statements",
            "Combinatorial Explosion",
            "Oddball Solution"
          ),
          new Module("A Catalog of Refactorings to Patterns",
            "Format of the Refactorings",
            "Projects Referenced in This Catalog",
            "A Starting Point",
            "A Study Sequence"
          ),
          new Module("Creation",
            "Replace Constructors with Creation Methods",
            "Move Creation Knowledge to Factory",
            "Encapsulate Classes with Factory",
            "Introduce Polymorphic Creation with Factory Method",
            "Encapsulate Composite with Builder",
            "Inline Singleton"
          ),
          new Module("Simplification",
            "Compose Method",
            "Replace Conditional Logic with Strategy",
            "Move Embellishment to Decorator",
            "Replace State-Altering Conditionals with State",
            "Replace Implicit Tree with Composite",
            "Replace Conditional Dispatcher with Command"
          ),
          new Module("Generalization",
            "Form Template Method",
            "Extract Composite",
            "Replace One-Many Distinctions with Composite",
            "Replace Hard-Coded Notifications with Observer",
            "Unify Interfaces with Adapter",
            "Extract Adapter",
            "Replace Implicit Language with Interpreter"
          ),
          new Module("Protection",
            "Replace Type Code with Class",
            "Limit Instantiation with Singleton",
            "Introduce Null Object"
          ),
          new Module("Accumulation",
            "Move Accumulation to Collecting Parameter",
            "Move Accumulation to Visitor"
          ),
          new Module("Utilities",
            "Chain Constructors",
            "Unify Interfaces",
            "Extract Parameter"
          )
        )
      },
      {"SE030CS", new Course("SE030CS","Advanced C#",
          new Module("Prerequisite",
            "Information Hiding",
            "OOP",
            "More advance C# features"
          ),
          new Module("Attributes",
            "Overview of Attributes",
            "Defining Custom Attributes",
            "Retrieving Attribute Values"
          ),
          new Module("Reflection, Metadata, And Emitting Objects",
            "Reflecting on Objects",
            "Adding Assembly Metadata",
            "Emitting Objects by Using Builder Classes"
          ),
          new Module("Delegates",
            "Comparing a Static Method with an Instance Method",
            "Single Cast Delegates",
            "Multicast Delegates",
            "Variance in Delegates"
          ),
          new Module("Events",
            "Creating Custom Events",
            "Passing Data to an Event Argument",
            "Using Event Accessors",
            "Handling Interface Events",
            "Handling Explicit Interface Events"
          ),
          new Module("Lambda Expressions",
            "The Usefulness of Lambda Expressions",
            "Lambda Expression with (and Without) Parameters",
            "Types of Lambda Expressions",
            "Expression-Bodied Members",
            "Local Variables in a Lambda Expression",
            "Using Tuples in a Lambda Expression",
            "Event Subscription with Lambda Expressions"
          ),
          new Module("Generic Programming",
            "The Motivation Behind Generics",
            "A Quick Look into the List Class",
            "Generic Delegates",
            "Predicate Delegate",
            "The Default Keyword in Generics",
            "Implementing Generic Interface",
            "Generic Constraints",
            "Using Covariance and Contravariance",
            "Covariance with Generic Delegate",
            "Covariance with Generic Interfaces",
            "Contravariance with Generic Delegates",
            "Contravariance with Generic Interface",
            "Self-Referencing Generic Types"
          ),
          new Module("Thread Programming",
            "Foundations in Thread Programming",
            "Coding Multithreaded Programs in C#",
            "Using the ThreadStart Delegate",
            "Using the ParameterizedThreadStart Delegate",
            "Foreground Thread vs. Background Thread",
            "Thread Safety",
            "An Alternative Approach Using the Monitor Class",
            "Deadlock"
          ),
          new Module("Asynchronous Programming",
            "Using a Synchronous Approach",
            "Using Thread Class",
            "Using the ThreadPool Class",
            "Using Lambda Expressions with ThreadPool",
            "Using the IAsyncResult Pattern",
            "Using an Event-based Asynchronous Pattern (EAP)",
            "Understanding Tasks",
            "Using a Task-based Asynchronous Pattern (TAP)",
            "Asynchronous Programming with Async / Await"
          ),
          new Module("LINQ",
            "C# Features That Support LINQ",
            "Query Syntax and Method Syntax in LINQ",
            "Basic LINQ Query Operations",
            "Data Transformations with LINQ"
          )
        )
      },
      {"MOC55339", new Course("MOC55339","Programming in C#",
          new Module("C# Syntax",
            "Writing Applications in C# and .NET",
            "Types of Data and Expressions",
            "C# Language Constructs"
          ),
          new Module("C# Language Concepts",
            "Methods",
            "Method Overloading",
            "Exception Handling",
            "Monitoring"
          ),
          new Module("C# Structures, Collections and Events",
            "Structs",
            "Enums",
            "Built-in Collections",
            "Events"
          ),
          new Module("C# Classes",
            "Creating Classes",
            "Interfaces",
            "Understanding Generics in C#"
          ),
          new Module("C# Inheritance",
            "Hierarchies of Classes",
            "Polymorphism",
            "Extending Classes"
          ),
          new Module("Input and Output",
            "File I/O",
            "Serialization and Deserialization",
            "Streams"
          ),
          new Module("Database Access",
            "Entity Framework",
            "LINQ"
          ),
          new Module("Using the Network",
            "Web Services",
            "REST and OData",
            "ASP.NET Core MVC"
          ),
          new Module("Graphical User Interfaces",
            "Using UI Frameworks",
            "Data binding",
            "Styling the UI"
          ),
          new Module("Application Performance",
            "Multitasking",
            "Asynchronous Calls",
            "Dealing with Conflicts"
          ),
          new Module("C# Interop",
            "Dynamic Objects",
            "Managing Resources"
          ),
          new Module("Designing for Reuse",
            "Metadata",
            "Attributes",
            "Generating Code",
            "Assemblies"
          )
        )
      },
      //{"CS", new Course("CS","C#",
      //    new Module("",
      //      "",
      //      "",
      //      ""
      //    ),
      //    new Module("",
      //      "",
      //      "",
      //      ""
      //    )
      //  )
      //},
    };
    //---------- Books --------------
    static public List<Book> Books = new List<Book>(){
      new Book() {
        Category="MOC55339",
        Download="/eBooks/Pro CS 10 with .NET 6.pdf",
        Image="/eBooks/Pro CS 10 with .NET 6.jpg",
        Title="Pro C# 10 with .NET 6: Foundational Principles and Practices in Programming",
        ISBN="978-1-484-27868-0",Author="Andrew Troelsen, Phil Japikse",
        Year=2022, Publisher="Apress"
      },
      new Book() {
        Category="MOC55339",
        Download="/eBooks/High-Performance Programming in CS and .NET.pdf",
        Image="/eBooks/High-Performance Programming in CS and .NET.jpg",
        Title="High-Performance Programming in C# and .NET: Understand the nuts and bolts of developing robust, faster, and resilient applications in C# 10.0 and .NET 6",
        ISBN="978-1-800-56471-8",Author="Jason Alls",
        Year=2022, Publisher="Packt Publishing"
      },
      new Book() {
        Category="MOC20483,MOC55339,SE001CS",
        Download="/eBooks/Learn CS Quickly A Complete Beginner’s Guide to Learning CS, Even If You’re New to Programming.pdf",
        Image="~/eBooks/Learn CS Quickly A Complete Beginner’s Guide to Learning CS, Even If You’re New to Programming.jpg",
        Title="Learn C# Quickly A Complete Beginner’s Guide to Learning C#, Even If You’re New to Programming",
        ISBN="978-1-95-179137-7",Author="coll",
        Year=2020,Publisher="CodeQuickly"
      },
      new Book() {
        Category="MOC20483,MOC55339,SE030CS",
        Download="/eBooks/Getting Started with Advanced C Sharp-Upgrade Your Programming Skills.pdf",
        Image="~/eBooks/Getting Started with Advanced C Sharp-Upgrade Your Programming Skills.jpg",
        Title="Getting Started with Advanced C#: Upgrade Your Programming Skills",
        ISBN="978-1-48-425934-4",Author="Vaskaran Sarcar",
        Year=2020,Publisher="Apress"
      },
      new Book() {
        Category="MOC20483,MOC55339",
        Download="/eBooks/Pro CS 7-With .NET and .NET Core.pdf",
        Image="~/eBooks/Pro CS 7-With .NET and .NET Core.jpg",
        Title="Pro C# 7: With .NET and .NET Core",
        ISBN="978-1-4842-3017-6",Author="Andrew Troelsen, Philip Japikse",
        Year=2017,Publisher="Apress"
      },
      new Book() {
        Category="MOC20483,MOC55339,SE001CS",
        Download="/eBooks/Mastering Windows Presentation Foundation.pdf",
        Image="~/eBooks/Mastering Windows Presentation Foundation.jpg",
        Title="Mastering Windows Presentation Foundation: Build responsive UIs for desktop applications with WPF, 2nd Edition",
        ISBN="978-1-838-64004-0",Author="Sheridan Yuen",
        Year=2020,Publisher="Packt Publishing Ltd"
      },
      new Book() {
        Category="MOC20483,MOC55339",
        Download="/eBooks/Thinking in LINQ.pdf",
        Image="~/eBooks/Thinking in LINQ.jpg",
        Title="Thinking in LINQ: Harnessing the power of functional programing [programming] in .NET applications",
        ISBN="978-1-430-26845-1",Author="Sudipta Mukherjee",
        Year=2014,Publisher="Apress"
      },
      new Book() {
        Category="MOC20483,MOC55339,SE001CS",
        Download="/eBooks/Beginning Object-Oriented Programming with CS.pdf",
        Image="~/eBooks/Beginning Object-Oriented Programming with CS.jpg",
        Title="Beginning Object-Oriented Programming with C#",
        ISBN="978-1-118-33692-2",Author="Jack Purdum",
        Year=2012,Publisher="Wrox"
      },
      new Book() {
        Category="MOC20483,Exam",
        Download="/eBooks/Exam Ref 70-483 Programming in CS.pdf",
        Image="~/eBooks/Exam Ref 70-483 Programming in CS.jpg",
        Title="Exam Ref 70-483 Programming in C#",
        ISBN="978-1-509-30698-5",Author="Rob Miles",
        Year=2018,Publisher="Microsoft Press"
      },
      new Book() {
        Category="MOC20483,Exam",
        Download="/eBooks/The CS Programmer’s Study Guide (MCSD).pdf",
        Image="~/eBooks/The CS Programmer’s Study Guide (MCSD).jpg",
        Title="The C# Programmer’s Study Guide (MCSD): Exam: 70-483",
        ISBN="978-1-484-22859-3",Author="Ali Asad, Hamza Ali",
        Year=2017,Publisher="Apress"
      },
      new Book() {
        Category="SE005CS",
        Download="/eBooks/Pro .NET Benchmarking.pdf",
        Image="/eBooks/Pro .NET Benchmarking.jpg",
        Title="Pro .NET Benchmarking: The Art of Performance Measurement",
        ISBN="978-1-484-24940-6",Author="Andrey Akinshin",
        Year=2019, Publisher="Apress"
      },
      new Book() {
        Category="SE005CS",
        Download="/eBooks/Pro .NET Memory Management.pdf",
        Image="/eBooks/Pro .NET Memory Management.jpg",
        Title="Pro .NET Memory Management: For Better Code, Performance, and Scalability",
        ISBN="978-1-484-24026-7",Author="Konrad Kokosa",
        Year=2018, Publisher="Apress"
      },
      new Book() {
        Category="SE005CS",
        Download="/eBooks/Clean Code in CS.pdf",
        Image="/eBooks/Clean Code in CS.jpg",
        Title="Clean Code in C#: Refactor your legacy C# code base and improve application performance by applying best practices",
        ISBN="978-1-838-98297-3",Author="Jason Alls",
        Year=2020, Publisher="Packt Publishing"
      },

      new Book() {
        Category="SE005CS",
        Download="/eBooks/Pro .NET Performance.pdf",
        Image="/eBooks/Pro .NET Performance.jpg",
        Title="Pro .NET Performance: Optimize Your C# Application",
        ISBN="978-1-430-24458-5",Author="Sasha Goldshtein, Dima Zurbalev, Ido Flatow",
        Year=2012, Publisher="Apress"
      },
      new Book() {
        Category="SE005CS",
        Download="/eBooks/Effective CS (Covers CS 4.0).pdf",
        Image="/eBooks/Effective CS (Covers CS 4.0).jpg",
        Title="Effective C# (Covers C# 4.0): 50 Specific Ways to Improve Your C# (2nd Edition)",
        ISBN="978-0-321-65870-8",Author="Bill Wagner",
        Year=2010, Publisher="Addison-Wesley Professional"
      },
      new Book() {
        Category="SE005CS",
        Download="/eBooks/.NET Performance Testing and Optimization.pdf",
        Image="/eBooks/.NET Performance Testing and Optimization.jpg",
        Title=".NET Performance Testing and Optimization - The Complete Guide",
        ISBN="	978-1-906-43440-3",Author="Paul Glavich and Chris Farrell",
        Year=2010, Publisher="Red gate books"
      },
      new Book() {
        Category="SE005CS,SE030CS",
        Download="/eBooks/Async in CS 5.0.pdf",
        Image="/eBooks/Async in CS 5.0.jpg",
        Title="Async in C# 5.0",
        ISBN="978-1-449-33716-2",Author="Alex Davies",
        Year=2012, Publisher="O'Reilly Media"
      },
      new Book() {
        Category="MOC55339",
        Download="/eBooks/Pro Microservices in .NET 6.pdf",
        Image="/eBooks/Pro Microservices in .NET 6.jpg",
        Title="Pro Microservices in .NET 6: With Examples Using ASP.NET Core 6, MassTransit, and Kubernetes",
        ISBN="978-1-484-27832-1",Author="Sean Whitesell, Rob Richardson, Matthew D. Groves",
        Year=2022, Publisher="Apress"
      },
      new Book() {
        Category="MOC55339",
        Download="/eBooks/Software Architecture with CS 10 and .NET 6.pdf",
        Image="/eBooks/Software Architecture with CS 10 and .NET 6.jpg",
        Title="Software Architecture with C# 10 and .NET 6: Develop Software Solutions using Microservices, Devops, EF Core, and Design Pattern",
        ISBN="978-1-803-23525-7",Author="Gabriel Abbruzzese Francesco Baptista",
        Year=2022, Publisher="Packt Publishing Lomited"
      },
      new Book() {
        Category="MOC55339",
        Download="/eBooks/CS 10.epub",
        Image="/eBooks/CS 10.jpg",
        Title="C# 10: More on WPF",
        ISBN="978-8-740-33701-3",Author="Poul Klausen",
        Year=2021, Publisher="Bookboon.com Ltd."
      },

      //new Book() {
      //  Category="CS",
      //  Download="/eBooks/.pdf",
      //  Image="/eBooks/.jpg",
      //  Title="",
      //  ISBN="",Author="",
      //  Year=2021, Publisher=""
      //},
    };
    static public List<Exam> Exams = new List<Exam>() {
      //---------- Exams --------------
      //new Exam() {
      //  Category="AZ900T01",
      //  Desc="Skills Measured",
      //  Download="/DOC/AZ900T01/exam-az-900-microsoft-azure-fundamentals-skills-measured.pdf",
      //  Version="25/Oct/2021"
      //},
    };
  }
}