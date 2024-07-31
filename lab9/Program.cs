using System;
// Generic class
class Container<T>
{
    public T Value { get; set; }
    public Container(T value)
    {
        Value = value;
    }
}
// Generic method
class Program
{
    public static void ShowValue<T>(T value)
    {
        Console.WriteLine("Value: " + value);
    }
    static void Main()
    {
        // Using the generic class
        var intContainer = new Container<int>(42);
        var stringContainer = new Container<string>("Generics!");
        // Using the generic method
        ShowValue(intContainer.Value);
        ShowValue(stringContainer.Value);
    }
}
