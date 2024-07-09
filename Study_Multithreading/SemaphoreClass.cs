using System;
using System.Threading;

namespace Study_Multithreading
{
    /*
    class SemaphoreClass
    {
        static void Main()
        {
            MyClass _myClass = new MyClass();

            //  10개 Thread 실행.
            //  처음 5개만 먼저 실행. 하나씩 해제와 함께 실행될 것
            for (int i = 1; i <= 10; i++)
            {
                new Thread(_myClass.Run).Start(i);
            }
        }
    }
    class MyClass
    {
        private Semaphore _semaphore;

        public MyClass()
        {
            //  5개의 Thread만 허용
            _semaphore = new Semaphore(5, 5);
        }
        public void Run(object obj)
        {
            //  Thread가 가진 Data (일련 번호)
            Console.WriteLine(obj);

            //  최대 5개 Thread만 아래 문장 실행
            _semaphore.WaitOne();

            Console.WriteLine(" Running # " + obj);
            Thread.Sleep(500);

            //  semaphore 1개 해체
            //  이후 다음 Thread WaitOne()에서 진입 가능
            _semaphore.Release();
        }
    }
    */
}