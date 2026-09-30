# Displaying an Exception’s Default Message


Every exception (error) in C# is an object
That object has a property called Message which 
stores a description of the error.
The Exception object's Message property holds the exception's default error message.
You can use the following format 


#  3.8 Using Named Constants


A named constant is a name that represents a value 
that cannot be changed during the program’s execution
In a constant can be declared by const keyword:

const double INTEREST_RATE = 0.129;

Writing the name of a constant in uppercase 
letters is traditional in many programming languages 
but is not a requirement.



# 3.9 Declaring Variables as Fields


A field is a variable that is declared at the class level
It is declared inside the class, but not inside of any method
A field’s scope is the entire class
In the following FieldDemo application, the name variable
 is a field that is declared in the Form1 class
The name field is created in memory when the Form1 form is created


# 3.10 Using the Math Class


The .NET Math class provides several methods for 
performing complex mathematical calculations
Math.Sqrt(x): returns the square root of x (a double).
Math.Pow(x, y): returns the value of x raised to the power of y.
 Both x and y are double.
Math.Max(x, y): Returns the greater of the two values x and y
Math.Min(x, y):Returns the lesser of the two values x and y.
Math.Round(x) :Returns the value of x (a double or a decimal)
 rounded to the nearest integer.
There are two predefined constants:
Math.PI: represents the ratio of the circumference of 
a circle to its diameter.
Math.E: represents the natural logarithmic base


# Tab Order (1 of 2)


To set the tab order of a control, click Tab Order
 on the View menu. This activates the tab-order 
 selection mode on the form.
Simply click the controls with the mouse in the order you want.
Notice that Label controls do not accept 
input from the keyboard. They cannot receive focus.
Their TabIndex values are irrelevant



