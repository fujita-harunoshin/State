﻿namespace State;

internal class Program
{
    static void Main(string[] args)
    {
        var context = new Context(new ConcreteStateA());
        context.Request1();
        context.Request2();
    }
}
