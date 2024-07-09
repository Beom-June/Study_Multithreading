using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Multithreading
{
    /*
    class TaskTClass
    {
        static void Main(string[] args)
        {
            // Task<T>를 이용하여 쓰레드 생성과 시작
            Task<int> _task = Task.Factory.StartNew<int>(() => CalcSize("Hello World"));

            // 메인쓰레드에서 다른 작업 실행
            Thread.Sleep(1000);

            // 쓰레드 결과 리턴. 쓰레드가 계속 실행중이면
            // 이곳에서 끝날 때까지 대기함
            int _result = _task.Result;

            Console.WriteLine("Result = {0}", _result);
        }

        static int CalcSize(string data)
        {
            string s = data == null ? "" : data.ToString();
            // 복잡한 계산 가정

            return s.Length;
        }
    }
    */
}
