using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Study_Multithreading
{
    /*
    class MonitorClassWaitPulse
    {
        static Queue _q = new Queue();
        static object _lockObj = new object();
        static bool _running = true;

        static void Main(string[] args)
        {
            // reader 쓰레드 시작
            Thread _reader = new Thread(ReadQueue);
            _reader.Start();

            // writer 쓰레드들 시작
            List<Thread> _thrds = new List<Thread>();
            for (int i = 0; i < 10; i++)
            {
                var t = new Thread(new ParameterizedThreadStart(WriteQueue));
                t.Start(i);
                _thrds.Add(t);
            }
            // 모든 writer가 종료될 때까지 대기
            _thrds.ForEach(p => p.Join());

            // reader 종료
            _running = false;
        }

        static void WriteQueue(object val)
        {
            lock (_lockObj)
            {
                _q.Enqueue(val);
                Console.WriteLine("W:{0}", val);
                Monitor.Pulse(_lockObj);
            }
        }

        static void ReadQueue()
        {
            while (_running)
            {
                lock (_lockObj)
                {
                    while (_q.Count == 0)
                    {
                        Monitor.Wait(_lockObj);
                    }

                    int qCount = _q.Count;
                    for (int i = 0; i < qCount; i++)
                    {
                        int val = (int)_q.Dequeue();
                        Console.WriteLine("R:{0}", val);
                    }
                }
            }
        }
    }
    */
}