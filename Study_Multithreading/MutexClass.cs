using System;
using System.Threading;
using System.Collections.Generic;

namespace Study_Multithreading
{
    /*
    class MutexClass
    {
        static void Main(string[] args)
        {
            //  2개의 쓰레드 실행
            Thread _t1 = new Thread(() => MyClass.AddList(10));
            Thread _t2 = new Thread(() => MyClass.AddList(20));
            _t1.Start();
            _t2.Start();

            //  2개의 Thread 실행 완료까지 대기
            _t1.Join();
            _t2.Join();

            // Main Thread 에서 Mutex 사용
            using (Mutex _mtx = new Mutex(false, "MutexName1"))
            {
                // Mutex 를 취득하기 위해 10 ms 대기
                if (_mtx.WaitOne(10))
                {
                    // 뮤텍스 취득후 MyList 사용
                    MyClass._myList.Add(30);
                }
                else
                {
                    Console.WriteLine("Cannot acquire mutex");
                }
            }
            MyClass.ShowList();
        }
    }

    public class MyClass
    {
        //  MutexName1 이라는 뮤텍스 생성
        private static Mutex _mtx = new Mutex(false, "MutexName1");

        //  Data Member
        public static List<int> _myList = new List<int>();

        //  Data를 List에 추가
        public static void AddList(int val)
        {
            //  먼저 Mutex를 취득할 때 까지 대기
            _mtx.WaitOne();

            //  Mutex 취득 후 실행 블럭
            _myList.Add(val);

            //  Mutex 해제
            _mtx.ReleaseMutex();
        }
        //  List 출력
        public static void ShowList()
        {
            _myList.ForEach(p => Console.WriteLine(p));
        }
    }
    */
}