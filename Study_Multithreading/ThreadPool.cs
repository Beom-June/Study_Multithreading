using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Multithreading
{
    /*
    class ThreadPool
    {
        static void Main(string[] args)
        {
            // 파라미터 없는 ThreadStart 사용
            Thread _t1 = new Thread(new ThreadStart(Run));
            _t1.Start();

            // ParameterizedThreadStart 파라미터 전달
            // Start()의 파라미터로 radius 전달
            Thread _t2 = new Thread(new ParameterizedThreadStart(Calc));
            _t2.Start(10.00);

            // ThreadStart에서 파라미터 전달
            Thread _t3 = new Thread(() => Sum(10, 20, 30));
            _t3.Start();
        }

        static void Run()
        {
            Console.WriteLine("Run");
        }

        // radius라는 파라미터를 object 타입으로 받아들임
        static void Calc(object radius)
        {
            double _r = (double)radius;
            double _area = _r * _r * 3.14;
            Console.WriteLine("r={0},area={1}", _r, _area);
        }

        static void Sum(int d1, int d2, int d3)
        {
            int _sum = d1 + d2 + d3;
            Console.WriteLine(_sum);
        }
    }
    */
}