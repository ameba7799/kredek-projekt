using System;
using System.Threading;

namespace Animation {

    public abstract class Animate {

        public void animate () {
            while (true) {
                nextFrame();
                Thread.Sleep(100);
            }
        } 

        public abstract void nextFrame ();

    }
}