using System;

namespace Stopwatch
{
    class Stopwatch
    {
        public static TimeSpan time = new TimeSpan();
        public static string state = "waiting";
        public static DateTime start;

        public void Run()
        {
            var input = Console.ReadLine();

            while (input == "start" || input == "stop")
            {
                if (input == "start")
                {
                    Start();
                }
                else if (input == "stop")
                {
                    Stop();
                }

                input = Console.ReadLine();
            }
        }

        public void Start()
        {
            if (state == "running")
                throw new InvalidOperationException("Stopwatch is already running");

            state = "running";

            start = DateTime.Now;
        }

        public void Stop()
        {
            if (state == "waiting")
                throw new InvalidOperationException("Stopwatch is already waiting");

            state = "waiting";

            var end = DateTime.Now;

            var duration = end - start;

            Console.WriteLine(duration);
        }
    }
}
