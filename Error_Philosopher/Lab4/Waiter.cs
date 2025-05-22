using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Waiter
    {
        private Semaphore waiter;

        public Waiter(int numWaiters)
        {
            waiter = new Semaphore(numWaiters, numWaiters);
        }

        public void GetWaitersAttention()
        {
            waiter.WaitOne();
        }

        public void ReleaseWaitersAttention()
        {
            waiter.Release();
        }
    }

}
