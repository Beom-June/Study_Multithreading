using System;
using System.IO;
using System.Net;
using System.Timers;

namespace Study_Multithreading
{
    /*
    class awaitTest
    {
        static void Main(string[] args)
        {
            // 타이머 생성 및 시작
            Timer timer = new System.Timers.Timer();
            //timer.Interval = 60 * 60 * 1000; // 1 시간
            timer.Interval = 1; 
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        // 쓰레드풀의 작업쓰레드가 지정된 시간 간격으로
        // 아래 이벤트 핸들러 실행
        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // 웹페이지 html문을 다운로드
            WebClient web = new WebClient();
            string webpage = web.DownloadString("http://mssql.tools");

            // 다운로드 내용을 파일에 저장
            string time = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            string outputFile = string.Format("page_{0}.html", time);
            File.WriteAllText(outputFile, webpage);
        }
    }
    */
}