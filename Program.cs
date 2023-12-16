using System.Diagnostics;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Prog2 {

    class Program
    {   
        public enum TaskType { MultN, MultY, EDiff, DCond }
        public static void Main(string[] args)
        {
            Console.WriteLine($"3 {Solve("17.txt", TaskType.EDiff, 31)}");
            Console.WriteLine($"4 {Solve("17(1).txt", TaskType.EDiff, 19)}");
            Console.WriteLine($"5 {Solve("17(2).txt", TaskType.MultY, 10)}");
            Console.WriteLine($"6 {Solve("17(3).txt", TaskType.MultY, 62)}");
            Console.WriteLine($"7 {Solve("17(4).txt", TaskType.MultN, 14)}");
            Console.WriteLine($"8 {Solve("17(5).txt", TaskType.MultN, 34)}");
            Console.WriteLine($"9 {Solve("17(6).txt", TaskType.MultY, 26)}");
            Console.WriteLine($"10 {Solve("17(7).txt", TaskType.DCond, 3)}");
            Console.WriteLine($"11 {Solve("17(8).txt", TaskType.DCond, 5)}");
            Console.WriteLine($"12 {Solve("17(9).txt", TaskType.MultY, 7)}");
            Console.WriteLine($"13 {Solve("17(10).txt", TaskType.MultY, 9)}");
            Console.WriteLine($"14 {Solve("17(11).txt", TaskType.MultY, 8)}");
            Console.WriteLine($"15 {Solve("17(12).txt", TaskType.MultY, 10)}");
            Console.WriteLine($"16 {Solve("17(13).txt", TaskType.MultY, 117)}");
            Console.WriteLine($"17 {Solve("17(14).txt", TaskType.MultY, 120)}");
            Console.WriteLine($"18 {Solve("17(15).txt", TaskType.MultY, 126)}");
            Console.WriteLine($"19 {Solve("17(16).txt", TaskType.MultY, 80)}");
        }

        public static List<int> ReadFile(string path)
        {
            List<int> list = new List<int>();
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                list.Add(int.Parse(line));
            }
            return list;
        
        }

        public static int CalculateSums(List<(int, int)> input) {
            List<int> sums = new List<int>();

            foreach((int item1, int item2) in input) {
                sums.Add(item1 + item2);
            }
            
            return sums.Max();
        }

        public static List<(int, int)> Solve1000PositiveEDiff(List<int> buffer, int divisor) {
            List<(int, int)> pairs = new List<(int, int)>();
            
            for (int i = 0; i < buffer.Count; i++) {
                for (int j = i + 1; j < buffer.Count; j++) {
                    if (i == j) continue;
                    if (((Math.Abs(buffer[i] - buffer[j]) % 2) != 0) || (((buffer[i] % divisor) != 0) && ((buffer[j] % divisor) != 0))) continue;
                    else {
                        pairs.Add((i, j));
                    }
                }
            }

            return pairs;
        }

        public static List<(int, int)> Solve1000PositiveMultY(List<int> buffer, int num) {
            List<(int, int)> pairs = new List<(int, int)>();
            
            for (int i = 0; i < buffer.Count; i++) {
                for (int j = i + 1; j < buffer.Count; j++) {
                    if (i == j) continue;
                    if (((buffer[i] * buffer[j]) % num) != 0) continue;
                    else {
                        pairs.Add((i, j));
                    }
                }
            }

            return pairs;
        }

        public static List<(int, int)> Solve1000PositiveDCond(List<int> buffer, int num) {
            List<(int, int)> pairs = new List<(int, int)>();
            
            for (int i = 0; i < buffer.Count; i++) {
                for (int j = i + 1; j < buffer.Count; j++) {
                    if (i == j) continue;
                    if ((((buffer[i] + buffer[j]) % 2) == 0) || (((buffer[i] * buffer[j]) % num) != 0)) continue;
                    else {
                        pairs.Add((i, j));
                    }
                }
            }

            return pairs;
        }


        public static List<(int, int)> Solve1000PositiveMultN(List<int> buffer, int num) {
            List<(int, int)> pairs = new List<(int, int)>();
            
            for (int i = 0; i < buffer.Count; i++) {
                for (int j = i + 1; j < buffer.Count; j++) {
                    if (i == j) continue;
                    if (((buffer[i] * buffer[j]) % num) == 0) continue;
                    else {
                        pairs.Add((i, j));
                    }
                }
            }

            return pairs;
        }

        public static string Solve(string filename, TaskType type, int num) {
            List<int> buffer = ReadFile(filename);

            List<(int, int)> pairs = new List<(int, int)>();

            switch (type) { 
                case TaskType.MultN:
                    pairs = Solve1000PositiveMultN(buffer, num);
                    break;
                case TaskType.MultY:
                    pairs = Solve1000PositiveMultY(buffer, num);
                    break;
                case TaskType.EDiff:
                    pairs = Solve1000PositiveEDiff(buffer, num);
                    break;
                case TaskType.DCond:
                    pairs = Solve1000PositiveDCond(buffer, num);
                    break;
            }

            return $"{pairs.Count} {CalculateSums(pairs)}";
        }
    }
}