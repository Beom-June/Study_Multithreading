using System;
using System.Threading;

namespace Study_Multithreading
{
    /*
    class AutoResetEventClass
    {
        // AutoResetEvent 객체 필드
        static AutoResetEvent _autoEvent = new AutoResetEvent(false);

        static void Main()
        {
            // 쓰레드 A 생성
            Thread _A = new Thread(Run);
            _A.Name = "Thread A";
            _A.Start();

            // 메인쓰레드            
            Thread.Sleep(3000); //3초 대기
            _autoEvent.Set(); // 쓰레드 A에 신호
        }

        static void Run()
        {
            string _name = Thread.CurrentThread.Name;
            Console.WriteLine("{0}: Run Start", _name);

            // AutoResetEvent 신호 대기
            _autoEvent.WaitOne();
            Console.WriteLine("{0} : DoWork", _name);

            Console.WriteLine("{0}: Run End", _name);
        }
    }
    */
}