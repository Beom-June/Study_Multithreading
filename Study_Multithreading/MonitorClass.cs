using System;
using System.Threading.Tasks;
using System.Threading;

namespace Study_Multithreading
{
    /*
    class MonitorClass
    {
        private int _cnt = 1000;

        // lock문에 사용될 객체(
        private object _lockObj = new object();

        public void Run()
        {
            // 10개의 쓰레드가 동일 메서드 실행
            for (int i = 0; i < 10; i++)
            {
                new Thread(SafeCalc).Start();
            }
        }

        // Thread-Safe하지 않은 메서드 
        private void SafeCalc()
        {
            // 한번에 한 쓰레드만 lock블럭 실행
            Monitor.Enter(_lockObj);
            try
            {

                // 필드값 변경
                _cnt++;

                // 가정 : 다른 복잡한 일을 한다
                for (int i = 0; i < _cnt; i++)
                    for (int j = 0; j < _cnt; j++) ;

                // 필드값 읽기
                Console.WriteLine(_cnt);
            }
            finally
            {
                Monitor.Exit(_lockObj);
            }
        }
        static void Main(string[] args)
        {
            MonitorClass _monitorClass = new MonitorClass();
            _monitorClass.Run();

            // 메인 쓰레드가 종료되지 않도록 대기
            Console.ReadLine();
        }
    }
    */
}