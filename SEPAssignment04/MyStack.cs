namespace SEPAssignment04;

public class MyStack<T>
{
    private Stack<T> _stack = new Stack<T>();

    public int Count()
    {
        return _stack.Count;
    }

    public T Pop()
    {
        return _stack.Pop();
    }

    public void Push(T element)
    {
        _stack.Push(element);
    }
}