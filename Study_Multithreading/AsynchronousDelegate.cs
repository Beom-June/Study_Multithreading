using System;
using System.Threading.Tasks;

namespace Study_Multithreading
{
    /*
    //  비동기 델리게이트
    class AsynchronousDelegate
    {
        static void Main(string[] args)
        {
            // 비동기 메서드를 동기적으로 호출
            int result = GetAreaAsync(10, 20).GetAwaiter().GetResult();
            // Task의 결과를 기다림
            //int result = await workTask;
            Console.WriteLine("Do something in Main thread");

            Console.WriteLine("Result: {0}", result);
        }

        static async Task<int> GetAreaAsync(int height, int width)
        {
            // Task로 비동기 실행
            int area = await Task.Run(() => GetArea(height, width));
            return area;
        }

        static int GetArea(int height, int width)
        {
            int area = height * width;
            return area;
        }
    }
    */
}