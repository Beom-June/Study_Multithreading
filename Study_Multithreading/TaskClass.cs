using System;
using System.Threading.Tasks;

namespace Study_Multithreading
{
    /*
    class TaskClass
    {
        //static void Main(string[] args)
        //{
        //    // Task.Factory를 이용하여 쓰레드 생성과 시작
        //    Task.Factory.StartNew(new Action<object>(Run), null);
        //    Task.Factory.StartNew(new Action<object>(Run), "1st");
        //    Task.Factory.StartNew(Run, "2nd");

        //    Console.Read();
        //}

        //static void Run(object data)
        //{
        //    Console.WriteLine(data == null ? "NULL" : data);
        //}
        static void Main(string[] args)
        {
            // Task 생성자에 Run을 지정 Task 객체 생성
            Task _t1 = new Task(new Action(Run));

            // 람다식을 이용 Task객체 생성
            Task _t2 = new Task(() =>
            {
                Console.WriteLine("Long query");
            });

            // Task 쓰레드 시작
            _t1.Start();
            _t2.Start();

            // Task가 끝날 때까지 대기
            _t1.Wait();
            _t2.Wait();
        }

        static void Run()
        {
            Console.WriteLine("Long running method");
        }
    }
    */
}
