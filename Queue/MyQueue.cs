using System;
using System.Collections.Generic;

public class MyQueue<T>
{
    private List<T> items;

    public MyQueue()
    {
        items = new List<T>();
    }

    public void Enqueue(T item)
    {
        items.Add(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is Empty");
        }

        T frontElement = items[0];
        items.RemoveAt(0);
        return frontElement;
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    public int Count()
    {
        return items.Count;
    }
}

public class MyQueue2<T>
{
    private class Node
    {
        public T Data { get; }
        public Node Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node front;
    private Node rear;

    public MyQueue2()
    {
        front = null;
        rear = null;
    }
        
    public void Enqueue(T item)
    {
        Node newNode = new Node(item);

        if (rear == null)
        {
            front = newNode;
            rear = newNode;
        }
        else
        {
            rear.Next = newNode;
            rear = newNode;
        }
    }

    public T Dequeue()
    {
        if (front == null)
        {
            throw new InvalidOperationException("Queue is Empty");
        }

        T data = front.Data;
        front = front.Next;

        if (front == null)
        {
            rear = null;
        }

        return data;
    }
    
    public bool IsEmpty()
    {
        return front == null;
    }

    public int Count()
    {
        int count = 0;
        Node current = front;

        while (current != null)
        {
            count ++;
            current = current.Next;
        }

        return count;
    }
}
