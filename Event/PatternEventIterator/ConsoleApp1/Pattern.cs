﻿//using System.Collections;

//class Client
//{
//    public void Main()
//    {
//        Aggregate a = new ConcreteAggregate();
//        Iterator i = a.CreateIterator();
//        object item = i.First;
//        while (!i.IsDone())
//        {
//            item = i.Next();
//        }
//    }
//}

//abstract class Aggregate
//{
//    public abstract Iterator CreateIterator();
//    public abstract int Count{ get; protected set; }
//    public abstract object this[int index] { get; set; }
//}
//class ConcreteAggregate : Aggregate
//{
//    private readonly ArrayList _items = new ArrayList();
//    public override Iterator CreateIterator()
//    {
//        return new ConreteIterator(this);
//    }
//    public override int Count
//    {
//        get { return _items.Count; }
//        protected set { }

//    }
//    public object this[int index]
//    {
//        get { return _items[index]; }
//        set { _items.Insert(index, value); }
//    }

//}
//abstract class Iterator
//{
//    public abstract object First();
//    public abstract object Next();
//    public abstract bool IsDone();
//    public abstract object CurrentItem();
//}
//class ConreteIterator : Iterator
//{
//    private readonly Aggregate _aggregate;
//    private int _current;
//    public ConreteIterator(Aggregate aggregate)
//    {
//        this._aggregate = aggregate;
//    }
//    public override object First()
//    {
//        return _aggregate[0];
//    }
//    public override object Next()
//    {
//        object ret = null;
//        _current++;
//        if (_current< _aggregate.Count) { 
//            ret = _aggregate[_current];
//        }
//        return ret;
//    }
//    public override object CurrentItem()
//    {
//        return _aggregate[_current];
//    }
//    public override bool IsDone()
//    {
//        return _current >= _aggregate.Count;
//    }


//}