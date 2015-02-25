using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.Memento
{
    public class FouluRecorder
    {
        private Foulu foulu;
        private List<Memento> mementos;
        private int currentIndex = -1;

        public FouluRecorder(Foulu foulu)
        {
            this.foulu = foulu;
            this.mementos = new List<Memento>();
        }

        public void Record()
        {
            this.mementos.Add(this.foulu.Memento);
            ++currentIndex;
        }

        public void Reset()
        {
            this.mementos.Clear();
            this.currentIndex = -1;
        }

        public void Rewind()
        {
            if (this.currentIndex > 0)
            {
                this.foulu.Memento = this.mementos.ElementAt(--currentIndex);
            }
        }

        public void Foward()
        {
            if (this.currentIndex < this.mementos.Count - 1)
            {
                this.foulu.Memento = this.mementos.ElementAt(++currentIndex);
            }
        }
    }
}
