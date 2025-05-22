using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Philosopher
    {
        private Table table;
        private int leftFork;
        private int rightFork;
        private int id;

        public Philosopher(int id, Table table)
        {
            this.id = id;
            this.table = table;

            rightFork = id;
            leftFork = (id + 1) % 5;

            // Варіант, якщо один з філософів "неправильний"
            
            //if (id < 4)
            //{
            //    rightFork = id;
            //    leftFork = (id + 1) % 5;
            //}
            //else
            //{
            //    leftFork = id;
            //    rightFork = (id + 1) % 5;
            //}
            

            new Thread(Run).Start();
        }

        private void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Philosopher {id} is thinking {i + 1} times");
                table.StartEating();

                table.GetFork(rightFork);
                table.GetFork(leftFork);

                Console.WriteLine($"Philosopher {id} is eating {i + 1} times");

                table.PutFork(leftFork);
                table.PutFork(rightFork);

                table.StopEating();
            }
        }
    }

}
