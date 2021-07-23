using System;
using System.Collections.Generic;
using System.Text;
/*
 * Chapter 9 Programming Based on Events 
 * - Define, create, and use delegates and examine their relationship to events. 
 * - Explore event-handling procedures in C#.
 * - Create applications that use the ListBox control object. 
 * - Contrast ComboBox to ListBox objects.
 * - Add Menu and TabControls.
 * - Wire multiple RadioButton and CheckBox object events to a single event-handler. 
 * 
 * Delegates form the foundation for events in C#. 
 * Delegates are special types of .NET classes whose instances store references (addresses)
 * to methods as opposed to storing actual data. 
 * 
 * In the English language, a delegate is a person who would as a sort of bridge between two 
 * entities. In C#, a delegate is often used a bridge between events and objects. 
 * 
 * For example, in the chapter 8 project, I used a button to call a method. When the button is 
 * clicked there are two things that happen. 
 * 1. The click event was registered as being of interest
 * 2. The event-hanlder method heading was generated. 
 * This is called "event wiring". This means that a event is associated with an event. 
 * 
 * Syntax: Event handler methods tend to all have a similar signature:
 * private void event_name(object sender, System.EventArgs e){
 *  -- Whatever the event is supposed to do goes here. 
 * }
 * 
 * Syntax: Events can easily associated with controls, for example:
 * this.button1.Click += new System.EventHandler(this.event_name);
 * This associates the button1 with the event_name method. It also states the action that 
 * will be recognized as being the cause, which is a Click. 
 * 
 */
namespace C_sharp_Programming
{
    class Chapter9
    {

        delegate string ReturnsSimpleString(); // Example 9-1, pg 481
        /*
         * When defining a delegate type, you identify what types of methods the delegate represents. 
         * It indicates what the method signature must look like.
         */

        /*
         * What is a delegate? 
         * It can be thought of as a way of defining or naming a method signature. 
         * Delegates remind me a little of a Java interface, from a syntax standpoint, but there seems 
         * to be more direct functionality involved. 
         */
        static string EndStatement() // Example 9-2, pg 481
        {
            return "in 10 years."; // This is used in Chapter9_DelegateExample
        }
        /*
         * Comparing Example 9-1 with Example 9-2, they have many similarities. They both have zero parameters and they
         * both return a string. The delegate Example 9-1 does not contain any body specifics. 
         */

        /*
         * A delegate is implemented as a class, but an instance of the delegate class is also referred to as a delegate. 
         * The delegate is never referred to as an object. 
         * Delegates are delegates are delegates. 
         */
    }
}
