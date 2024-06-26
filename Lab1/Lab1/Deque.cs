using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1;

class Node
{
    public int data;
    public Node? next;
    public Node? prev;
    public static Node GetNode(int data)
    {
        Node node = new();
        node.data = data;
        node.next = node.prev = null;
        return node;
    }
}
public class Deque
{
    Node? front;
    Node? end;
    int size;

    public Deque()
    {
        front = end = null;
        size = 0;
    }
    public bool IsEmpty()
    {
        return front == null;
    }
    public int Size()
    {
        return size;
    }
    public void PushFront(int data)
    {
        Node? node = Node.GetNode(data);
        if (node == null)
        {
            return;
        }
        else
        {
            if (front == null)
                front = end = node;
            else
            {
                node.next = front;
                front.prev = node;
                front = node;
            }
        }
    }
    public void PushBack(int data)
    {
        Node node = Node.GetNode(data);
        if (node == null)
        {
            return;
        }
        else
        {
            if (end == null)
                front = end = node;
            else
            {
                node.prev = end;
                end.next = node;
                end = node;
            }
            size++;
        }

    }
    public int? PopFront()
    {
        if (IsEmpty())
        {
            return null;
        }
        int data = front.data;
        if (!IsEmpty())
        {
            Node temp = front;
            front = front.next;
            if (front == null)
                end = null;
            else
                front.prev = null;
            size--;
        }
        return data;
    }
    public int? PopEnd()
    {
        if (IsEmpty())
        {
            return null;
        }
        int data = end.data;
        if (!IsEmpty())
        {
            Node temp = end;
            end = end.prev;
            if (end == null)
                front = null;
            else
                end.next = null;
            size--;
        }
        return data;
    }

    public IEnumerable<int> GetAll()
    {
        Node ptr = front;
        while (ptr != null)
        {
            int data = ptr.data;
            ptr = ptr.next;
            yield return data;
        }
        yield break;
    }
} 
