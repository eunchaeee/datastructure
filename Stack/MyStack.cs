using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private List<T> items;

    public MyStack()
    {
        items = new List<T>();
    }

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is Empty");
        }
        T top = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return top;
    }

    public T Top()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is Empty");
        }
        T top = items[items.Count - 1];
        return top;
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    public int Size()
    {
        return items.Count;
    }
}

