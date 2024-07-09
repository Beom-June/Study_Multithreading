using System;
using System.Threading;

namespace Study_Multithreading
{
    /*
    class LockBlock
    {
        private int counter = 1000;

        // lock문에 사용될 객체
        private object _lockOb = new object();

        public void Run()
        {
            // 10개의 쓰레드가 동일 메서드 실행
            for (int i = 0; i < 10; i++)
            {
                new Thread(SafeCalc).Start();
            }
        }

        // Thread-Safe 메서드 
        private void SafeCalc()
        {
            // 한번에 한 쓰레드만 lock블럭 실행
            lock (_lockOb)
            {
                // 필드값 변경
                counter++;

                // 가정 : 다른 복잡한 일을 한다
                for (int i = 0; i < counter; i++)
                    for (int j = 0; j < counter; j++) ;

                // 필드값 읽기
                Console.WriteLine(counter);
            }
        }

        //출력 예:
        // 1001
        // 1002
        // 1003
        // 1004
        // 1005
        // 1006
        // 1007
        // 1008
        // 1009
        // 1010
        static void Main(string[] args)
        {
            LockBlock _lockBlock = new LockBlock();
            _lockBlock.Run();

            // 메인 쓰레드가 종료되지 않도록 대기
            Console.ReadLine();
        }
    }
    */
}