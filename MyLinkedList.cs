using System.Collections;

namespace LinkedListTemplate;

public class MyLinkedList : IMyList, IEnumerable<string>
{
    public void Insert(string element)
    {
        throw new NotImplementedException();
    }

    public int GetIndex(string element)
    {
        throw new NotImplementedException();
    }

    public bool Delete(string element)
    {
        throw new NotImplementedException();
    }

    public bool Contains(string element)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<string> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        return "implement me";
    }
}