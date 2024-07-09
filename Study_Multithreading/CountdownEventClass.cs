using System;
using System.Threading;

namespace Study_Multithreading
{
    /*
    class CountdownEventClass
    {
        // CountdownEvent 객체 필드
        static CountdownEvent _cntEvent = new CountdownEvent(5);

        static void Main()
        {
            // 10개의 쓰레드 시작
            // 10개중 5개만 Vote만 끝내면 중지            
            for (int i = 0; i < 10; i++)
            {
                new Thread(Vote).Start(i);
            }

            // 메인쓰레드 첫 5개 신호를 기다림
            _cntEvent.Wait();

            Console.WriteLine("Vote is done!");
        }

        static void Vote(object id)
        {
            if (_cntEvent.CurrentCount > 0)
            {
                // CountdownEvent 신호. -1씩 카운트다운.
                _cntEvent.Signal();

                Console.WriteLine("{0}: Vote", id);
            }
            else
            {
                Console.WriteLine("{0}: No vote", id);
            }
        }
    }
    */
}