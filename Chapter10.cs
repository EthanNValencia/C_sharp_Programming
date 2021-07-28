using System;
using System.Collections.Generic;
using System.Text;
/*
 * Chapter 10 Advanced Object-Oriented Programming
 * 
 * - Learn the major features of object-oriented languages.
 * - Design and develop multitier applications using component based development methods.
 * - Use inheritance to extend the functionality of user-defined classes.
 * - Create abstract classes that include abstract methods. 
 * - Become aware of partial classes.
 * - Design and implement interfaces.
 * - Understand why polymorphic programming is a common goal in .Net.
 * - Explore generic san dlearn how to create generic classes and generic methods. 
 */
namespace C_sharp_Programming
{
    /*
     *                      ---- OOP Features ---- 
     * 1. Abstraction     - The language must provide a way to manage complex problems by allowing you to abstract
     *                      or identify the objects involved in the problem. 
     * 2. Encapsulation   - The language must provide support for packaging data attributes and behaviors into a
     *                      single unit, thus hiding implementation details. 
     * 3. Inheritance     - The language must provide features that enable reuse of code through extending the 
     *                      functionality of the program units. 
     * 4. Polymorphism    - The language must enable multiple implementations of the same behaviors so that the
     *                      appropriate implementation can be executed based on the situation. 
     * 
     * Abstracting common characteristics that all objects of a certain class should have. These characteristics
     * both include behavioral and data.
     * The behavioral and data characteristics of a class are encapsulated into a single entity. Defining data 
     * members as private provide data protection and limit access to internally within the class. 
     * Inheritance is when an existing class is extended to another class, so that it's behavior and data types
     * can be used in the child class. 
     * -- Add a section for polymorphism --
     */

    /*
     * Inheritance, IS-A relationship. 
     * A truck IS A vehicle. A hawk IS A bird. A maple IS A tree. 
     * Inheritance is used to extend generalized features down to more specialized children. 
     * All objects inherit from the base object, just like Java.
     * object has 4 methods that every class inherits: ToString, GetType, GetHashCode, and Equals. 
     */

    /*
     * Inheritance, HAS-A(N) relationship. 
     * A truck HAS AN engine. A hawk HAS A feather. 
     * HAS A relationship is when a class contains another class. For example, if I create a class that requires
     * an instance of another class, then this is containment. Often this is done all the time without much 
     * consideration. 
     */

    /*
     *                  -- Component-Based Development --
     * Component based development, traditionally, has layered components. (listed front to back)
     * 1. The surface layer or the presentation layer. 
     * 2. The business logic layer.
     * 3. The data access component. 
     * 4. The database. 
     * 
     * The first, Presentation Layer, can vary a lot. It can be mobile, desktop-based, or even web-based.
     * 
     * In Windows, a DLL file can be created. This is a Dynamic Link Library. It is a way that class library
     * files can be stored. They can be referenced from a number of different applications. 
     */

    /*
     * --- Making A Stand-Alone Component ---
     * One of the cool things about DLL is that a class can be compiled and stored as a DLL. DLLs can be
     * accessed by other programs. 
     * 
     * I created two DLL through the visual studio command prompt. 
     * 
     * Tools > Command Line > Developer Command Prompt
     * 
     * The first I created I typed:
     * csc /target:library /out:Chapter10_Person.dll Chapter10_Person.cs
     * 
     * The second I created I typed: 
     * csc /target:library /out:Chapter10_Student.dll Chapter10_Student.cs Chapter10_Person.cs
     * 
     * The second DLL requires Chapter10_Person.cs, because it is a child of that class. It is necessary to
     * include it. 
     */

    /*                  -- DLL --
     * After a DLL is created, it is not easy to view its contents. In order to view it ILDASM must be 
     * used. It must be added as a tool.
     * Tools > External Tools > Add > add the exe to the command, "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\ildasm.exe"
     * Now IL DASM can be run from the Tools. Open the DLL and limited information about the contents of the DLL
     * can be viewed. Page 606 for more information.
     * 
     * Additional DLL info can be found in Chapter10_PresentationGUI and in Chapter10_PersonStudent.
     */


    class Chapter10
    {
    }

    /*                  -- Abstract Classes --
     * Pg 607 - 608
     * Abstract classes serve the same purpose in C# as they do in Java. 
     * They are instantiate, but rather they are implemented upon classes in order to 
     * give certain classes similarities. 
     * 
     * The syntax for creating an abstract class:
     * [access modifier] abstract class [class name] { }
     * 
     * Abstract class exmaple:
     * public abstract class Person { ... }
     * 
     * After a class is declared to be abstract it cannot be directly instantiated. 
     */
    public abstract class Person
    {
        /*
         * Every class that implements the Person abstract class will not have to
         * implement the GerExerciseHabits(). The compiler understands that abstract
         * classes will be overridden, so include the "virtual" keyword is not 
         * necessary. 
         */
        public abstract string GetExerciseHabits(); 
        public int ConvertNumber(int inputNum) // This method has a body. 
        {
            int number = 5;
            number *= inputNum;
            return number;
        }
    }

    /* Pg 609
     *                  -- Partial Classes --
     * Partial classes are used to split up class definitions across different files. 
     * When I created a GUI, the Form1 class is split into two partial classes. 
     * 
     * IMO: Partial classes seem like a feature that is good for when engaging in 
     * project development (with multiple programmers), but after the fact, it could 
     * make maintaining code a little more tedious. 
     * 
     * At compile time, the partials are merged into a unified class definition. 
     */
    public partial class ExamplePartialClass // This could be in one file.
    {
        int number = 0;
    }
    public partial class ExamplePartialClass // This could be in another file.
    {
        string name = "Name";
    }
    /*
     * The two partial classes are understood to be the same class. In practice,
     * it probably wouldn't be a good idea to place the same partials in the same
     * file, but for the sake of showing an example I am doing it here. 
     */

    /* pg 610
     *                   -- Interfaces --
     * A interface is similar to an abstract class, but there is no limit to how
     * many interfaces a class can implement. This is different, because a class
     * can only extend one abstract class. An abstract class can be used to
     * both implement and define functionality, but an interface only allows the 
     * ability to define functionality. 
     * 
     * The book recommends that interfaces should be defined as their own Class 
     * Library project. They can be converted into their own DLL. The reason why 
     * this is useful is because I can reap the benefits of component based development. 
     */
    public interface ExampleInterface
    {
        // Cannot contain instance fields. 
        string FindName();
        string GetDestination();
        double DetermineMiles();
    }
    public abstract class ExampleAbstractClass
    {
        public abstract string GetExerciseHabits();
        public int ConvertNumber(int inputNum) // This method has a body. 
        {
            int number = 5;
            number *= inputNum;
            return number;
        }
    }
    public class ExampleClass : ExampleAbstractClass, ExampleInterface // This class extends ExampleAbstractClass and implements the ExampleInterface. 
    {
        public override string GetExerciseHabits()
        {
            return "Jogging, Hiking";
        }
        public double DetermineMiles()
        {
            double num = 5;
            this.ConvertNumber(4); // This class knows about the methods in the interface. 
            return num;
        }

        public string FindName()
        {
            return "Matt";
        }

        public string GetDestination()
        {
            return "Mali, Africa";
        }
    }
    /* Example 10-22, pg 615
     * 
     * These are some of the collection class headings with their interfaces. 
     * 
     * public abstract class Array : ICloneable, IList, ICollection, IEnumerable
     * 
     * public class ArrayList : IList, ICollection, IEnumerable, ICloneable
     * public class Queue : ICollection, Inumerable, ICloneable
     * public class Stack : ICollection, Inumerable, ICloneable
     * public class HastTable : IDictionary, ICollection, Inumerable, ISerializable, 
     *                          IDeserializationCallback, ICloneable
     */

    /*                      ---- POLYMORPHISM ---- pg 615 - 617
     * It is the ability for classes to provide different implementations of methods that
     * are called by the same name. For example, with the collections, the Add() does different
     * things. Sure, it is used to add things to a collection, but the specifics of how that 
     * is achieved is different. 
     * 
     * An example of polymorphism in the English language is how we use the word "drive". Drive
     * can mean to "drive a car" or "drive a nail" or "drive a point" -- it changes depending
     * on the context and what the object of the conversation is. 
     * 
     * ToString() is a great example of polymorphism. It does a similar thing, but it differs in
     * its implementation depending on the object. 
     */
    
    public class GenericExample<T> // Example 10-26, pg 620
    {
        public T dataMember;
    }
}
