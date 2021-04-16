using System;

namespace Iterator
{
    public class ConcreteIterator : Iterator
    {
        public ConcreteAggregate _aggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            this._aggregate = concreteAggregate;
        }


        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            return (_current >= _aggregate.Count);
        }

        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }
            return ret;
        }
    }
}
