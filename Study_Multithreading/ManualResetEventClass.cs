using System;
using System.Threading;

namespace Study_Multithreading
{
    /*
    class ManualResetEventClass
    {
        static ManualResetEvent _manualEvent = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            //  Thread 생성.
            //  모두 _manualEvent.WaitOne();에서 실행 중지 후 대기중
            for (int i = 0; i < 10; i++)
            {
                new Thread(Run).Start(i);
            }

            //  Main Thread
            Thread.Sleep(3000);

            //  ManualResetEvent 객체 Set() 호출
            //  10개 쓰레드 모두 실행 계속함. 
            _manualEvent.Set();
        }

        static void Run(object id)
        {
            Console.WriteLine("{0} in Wait", id);

            //  ManualResetEvent 신호 대기
            _manualEvent.WaitOne();

            Console.WriteLine("{0} : Done", id);
        }
    }
    */
}