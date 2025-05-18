using System;
using System.Collections.Generic;

// The Subject
class Subject
{
    public int State { get; set; } = 0;

    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        Console.WriteLine("Subject: Attached an observer.");
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine("Subject: Detached an observer.");
    }

    public void Notify()
    {
        Console.WriteLine("Subject: Notifying observers...");

        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public void SomeBusinessLogic()
    {
        Console.WriteLine("\nSubject: I'm doing something important.");
        this.State = new Random().Next(0, 10);

        Console.WriteLine($"Subject: My state has just changed to: {this.State}");
        this.Notify();
    }
}

// The Observer interface
interface IObserver
{
    void Update(Subject subject);
}

// Concrete Observer A
class ConcreteObserverA : IObserver
{
    public void Update(Subject subject)
    {
        if (subject.State < 3)
        {
            Console.WriteLine("ConcreteObserverA: Reacted to the event.");
        }
    }
}

// Concrete Observer B
class ConcreteObserverB : IObserver
{
    public void Update(Subject subject)
    {
        if (subject.State == 0 || subject.State >= 2)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var subject = new Subject();

        var observerA = new ConcreteObserverA();
        subject.Attach(observerA);

        var observerB = new ConcreteObserverB();
        subject.Attach(observerB);

        subject.SomeBusinessLogic();
        subject.SomeBusinessLogic();

        subject.Detach(observerB);

        subject.SomeBusinessLogic();
    }
}
