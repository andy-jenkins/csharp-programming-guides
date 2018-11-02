# Static Members

## Intent
To raise awareness and demonstrate the danger
of static class members when (potentially accidentally) misused.

## Theory
From [Static Classes and Static Class Members](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members):

> A non-static class can contain static methods,
> fields, properties, or events.
> The static member is callable on a class
> even when no instance of the class has been created.
> The static member is always accessed by the class name,
> not the instance name.
> Only one copy of a static member exists,
> regardless of how many instances of the class are created.

> Static methods and properties cannot access non-static fields
> and events in their containing type,
> and they cannot access an instance variable of any object
> unless it is explicitly passed in a method parameter.