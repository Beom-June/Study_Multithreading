using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Study_Multithreading
{
    /*
    class ParallelClass
    {
        const int MAX = 10000000;
        const int SHIFT = 3;

        static void Main(string[] args)
        {
            SequentialEncrypt();
            ParallelEncrypt();
        }

        //  순차 처리
        static void SequentialEncrypt()
        {
            // 테스트 데이터 셋업
            string _text = "I am a boy. My name is Tom.";
            List<string> _textList = new List<string>(MAX);
            for (int i = 0; i < MAX; i++)
            {
                _textList.Add(_text);
            }

            // 순차 처리
            Stopwatch _watch = new Stopwatch();
            _watch.Start();
            for (int i = 0; i < MAX; i++)
            {
                char[] _chArr = _textList[i].ToCharArray();

                // 모든 문자를 시저 암호화
                for (int x = 0; x < _chArr.Length; x++)
                {
                    // 시저 암호
                    if (_chArr[x] >= 'a' && _chArr[x] <= 'z')
                    {
                        _chArr[x] = (char)('a' + ((_chArr[x] - 'a' + SHIFT) % 26));
                    }
                    else if (_chArr[x] >= 'A' && _chArr[x] <= 'Z')
                    {
                        _chArr[x] = (char)('A' + ((_chArr[x] - 'A' + SHIFT) % 26));
                    }
                }

                // 변경된 암호로 치환
                _textList[i] = new string(_chArr);
            }
            _watch.Stop();
            Console.WriteLine($"Sequential encryption took: {_watch.Elapsed}");
        }

        //  병렬 처리
        static void ParallelEncrypt()
        {
            // 테스트 데이터 셋업
            string _text = "I am a boy. My name is Tom.";
            List<string> _textList = new List<string>(MAX);
            for (int i = 0; i < MAX; i++)
            {
                _textList.Add(_text);
            }

            // 병렬 처리
            Stopwatch _watch = new Stopwatch();
            _watch.Start();
            Parallel.For(0, MAX, i =>
            {
                char[] _chArr = _textList[i].ToCharArray();

                // 모든 문자를 시저 암호화
                for (int x = 0; x < _chArr.Length; x++)
                {
                    // 시저 암호
                    if (_chArr[x] >= 'a' && _chArr[x] <= 'z')
                    {
                        _chArr[x] = (char)('a' + ((_chArr[x] - 'a' + SHIFT) % 26));
                    }
                    else if (_chArr[x] >= 'A' && _chArr[x] <= 'Z')
                    {
                        _chArr[x] = (char)('A' + ((_chArr[x] - 'A' + SHIFT) % 26));
                    }
                }

                // 변경된 암호로 치환
                _textList[i] = new string(_chArr);
            });
            _watch.Stop();
            Console.WriteLine($"Parallel encryption took: {_watch.Elapsed}");
        }
    }
    */
}