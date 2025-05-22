using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Table
    {
        private Semaphore[] forks = new Semaphore[5];
        private Waiter waiters = new Waiter(2);

        public Table()
        {
            for (int i = 0; i < forks.Length; i++)
            {
                forks[i] = new Semaphore(1, 1);
            }
        }

        public void GetFork(int id)
        {
            forks[id].WaitOne();
        }

        public void PutFork(int id)
        {
            forks[id].Release();
        }

        public void StartEating()
        {
            waiters.GetWaitersAttention();
        }

        public void StopEating()
        {
            waiters.ReleaseWaitersAttention();
        }
    }

}
