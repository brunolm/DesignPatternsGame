using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsGame.Observer
{
    public interface IGodEmperor
    {
        void Subscribe(IGodEmperorObserver observer);
        void Unsubscribe(IGodEmperorObserver observer);
        void Notify();
    }
}
