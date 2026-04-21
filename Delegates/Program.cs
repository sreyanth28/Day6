//Creating an instance of the "MathOperation" delegate and assigning it the "Add" method.




MathOperation operation = delgateDemo.Add;
Console.WriteLine("Delegate ref is created and currently it is pointing to Add()");
//invoking the delegate with two integers and displaying the result.
int result = operation(10, 5);
Console.WriteLine("Since Delegate is pointing to Add() so the result of Addition is " + result);

//Changing the delegate assignment to the "Subtract" method and invoking it again with the same integers, displaying the result.
operation = delgateDemo.Subtract;
Console.WriteLine("Now the delegate ref is changed and currently it is pointing to Subtract()");
result = operation(10, 5);
Console.WriteLine("Since Delegate is pointing to Subtract() so the result of Subtraction is " + result);

operation = delgateDemo.Multiply;
result=operation(10, 5);
Console.WriteLine(result);



//here we can have publish-subscriber model where MathOperation delegate can be used as a publisher and we can have multiple subscribers that want to receive notifications when a new math operation is performed.



//Step 1: Define a delegate type that specifies the signature of the method that the delegate can reference. (We have already defined the MathOperation delegate)
//Step 2: Create a class that will act as the publisher and define an event that uses the delegate type.
//(We can create a class called "MathPublisher" that has an event called "OnMathOperationPerformed" of type MathOperation)
//Step 3: Create a class that will act as the subscriber and define a method that matches the signature of the delegate. (We can create a class called "MathSubscriber" that has a method called "HandleMathOperation" that takes two integers as parameters and returns an integer as output)
//step 4: In the main method, create an instance of the publisher and subscribe the subscriber's method to the publisher's event.
//Step 5: Invoke the publisher's event to notify all subscribers when a new math operation is performed.


