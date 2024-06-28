# Adapter pattern

The Adapter pattern is a structural design pattern that allows objects with incompatible interfaces to collaborate. It's often used in situations where you want to use a class that doesn't have the interface you need, or when you want to create a reusable class that cooperates with unrelated or unforeseen classes.

In the context of .NET programming, the Adapter pattern can be particularly useful due to the extensive use of interfaces and the strong typing of the language. It can help to bridge the gap between two existing classes or interfaces that would otherwise be incompatible.

Here's a basic example of how the Adapter pattern might be implemented in C#:

![Adapter pattern](./Adapter.png)

```csharp
// Existing way requests are implemented
public class Adaptee
{
    public void SpecificRequest()
    {
        // Code here
    }
}

// New standard for requests
public interface ITarget
{
    void Request();
}

// Implementing the new standard in terms of the old
public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public void Request()
    {
        _adaptee.SpecificRequest();
    }
}
```

In this example, `Adaptee` is the existing class that performs some specific requests in a different way than the new standard. `ITarget` is the new standard for requests. `Adapter` is the class that implements the new standard in terms of the old; it translates calls to `Request` into calls to the `SpecificRequest` method of the `Adaptee` class. This allows the `Adaptee` to be used where an `ITarget` is expected.


Create a visual representation of the Adaptor pattern based on this example.


