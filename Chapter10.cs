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

    class Chapter10
    {
    }
}
