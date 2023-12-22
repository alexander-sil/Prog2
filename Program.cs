using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Prog2 {

    class Program
    {   
        public enum TaskType { MultN, MultY, EDiff, DCond }
        public static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine(Solve24_2("24.txt"));
        }
        public static int Solve24_1(string filename) {
            char[] data = ReadFileByChar(filename);
            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;
                    
                    if (!(data[i + 1].Equals(data[i]) && data[i].Equals(data[i - 1]))) {
                        @new++;
                    }

                    if (data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
=======
            Console.WriteLine("ВНИМАНИЕ! Вывод кода может иметь погрешность! Пожалуйста, относитесь с пониманием.");
            Console.WriteLine($"2 {Solve2("17o.txt")}");
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
>>>>>>> 8f14d4206884e1f31d7b6f6158c0302bd946d303
        }

        public static int Solve24_2(string filename) {
            char[] data = ReadFileByChar(filename);
            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;

                    if (data[i].Equals('X')) {
                        @new++;
                    }
                    
                    if (data[i + 1].Equals('X')) {
                        @new++;
                    }

                    if (!data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }
        
        public static int Solve24_3(string filename) {
            char[] data = ReadFileByChar(filename);
            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;

                    if (data[i].Equals('Y')) {
                        @new++;
                    }
                    
                    if (data[i + 1].Equals('Y')) {
                        @new++;
                    }

                    if (!data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }

        public static int Solve24_4(string filename) {
            char[] data = ReadFileByChar(filename);
            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;

                    if (data[i].Equals('Z')) {
                        @new++;
                    }
                    
                    if (data[i + 1].Equals('Z')) {
                        @new++;
                    }

                    if (!data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }
        public static int Solve24_5(string filename) {
            char[] rawdata = ReadFileByChar(filename);
            string data = new string(rawdata);

            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;

                    if (data.Contains("XYZ")) {
                        @new++;
                    }

                    if (!data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }

        public static int Solve24_6(string filename) {
            char[] data = ReadFileByChar(filename);
            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;
                    
                    if (!(data[i + 1].Equals(data[i]) && data[i].Equals(data[i - 1]))) {
                        @new++;
                    }

                    if (data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }

        public static int Solve24_7(string filename) {
            char[] data = ReadFileByChar(filename);
            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;

                    if (data[i].Equals('A')) {
                        @new++;
                    }
                    
                    if (data[i + 1].Equals('A')) {
                        @new++;
                    }

                    if (!data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }

        public static int Solve24_8(string filename) {
            char[] data = ReadFileByChar(filename);
            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;

                    if (data[i].Equals('B')) {
                        @new++;
                    }
                    
                    if (data[i + 1].Equals('B')) {
                        @new++;
                    }

                    if (!data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }

        public static int Solve24_9(string filename) {
            char[] data = ReadFileByChar(filename);
            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;

                    if (data[i].Equals('C')) {
                        @new++;
                    }
                    
                    if (data[i + 1].Equals('C')) {
                        @new++;
                    }

                    if (!data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }

        public static int Solve24_10(string filename) {
            char[] rawdata = ReadFileByChar(filename);
            string data = new string(rawdata);

            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;

                    if (data.Contains("AB")) {
                        @new++;
                    }

                    if (!data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }   
        public static int Solve24_11(string filename) {
            char[] data = ReadFileByChar(filename);
            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;
                    
                    if (!(data[i + 1].Equals(data[i]) && data[i].Equals(data[i - 1]))) {
                        @new++;
                    }

                    if (data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }
       
        public static int Solve24_12(string filename) {
            char[] data = ReadFileByChar(filename);
            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;

                    if (data[i].Equals('L')) {
                        @new++;
                    }
                    
                    if (data[i + 1].Equals('L')) {
                        @new++;
                    }

                    if (!data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }


        public static int Solve24_13(string filename) {
            char[] data = ReadFileByChar(filename);
            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;

                    if (data[i].Equals('D')) {
                        @new++;
                    }
                    
                    if (data[i + 1].Equals('D')) {
                        @new++;
                    }

                    if (!data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }
        public static int Solve24_14(string filename) {
            char[] data = ReadFileByChar(filename);
            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;

                    if (data[i].Equals('R')) {
                        @new++;
                    }
                    
                    if (data[i + 1].Equals('R')) {
                        @new++;
                    }

                    if (!data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        }

        public static int Solve24_15(string filename) {
            char[] rawdata = ReadFileByChar(filename);
            string data = new string(rawdata);

            List<int> lengths = new List<int>();

            for (int i = 0; i < data.Length; i++) {
                try {
                    int @new = default;

                    if (data.Contains("LDR")) {
                        @new++;
                    }

                    if (!data[i].Equals(data[i + 1])) {
                        lengths.Add(@new);
                    }
                }
                catch {
                    break;
                }
            }

            return lengths.Max();
        } 

        public static int Solve24_16(string filename) {
            string[] data = File.ReadAllLines(filename);
            int count = 0;

            foreach (string s in data) {
                int E = 0;
                int A = 0;

                foreach (char c in s) {
                    if (c.Equals('E')) E++; else if (c.Equals('A')) A++;
                }

                if (E > A) count++;

            }

            return count;
        }

        public static int Solve24_17(string filename) {
            string[] data = File.ReadAllLines(filename);
            int count = 0;

            foreach (string s in data) {
                int E = 0;
                int A = 0;

                foreach (char c in s) {
                    if (c.Equals('E')) E++; else if (c.Equals('A')) A++;
                }

                if (A > E) count++;

            }

            return count;
        }

        public static int Solve24_18(string filename) {
            string[] data = File.ReadAllLines(filename);
            List<KeyValuePair<int, char> pairs = new List<KeyValuePair<int, char>();
            
            foreach (string s in data) {
               try {
                int A = 0;
                int B = 0;
                int C = 0;
                int D = 0;
                int E = 0;
                int F = 0;
                int G = 0;
                int H = 0;
                int I = 0;
                int J = 0;
                int K = 0;
                int L = 0;
                int M = 0;
                int N = 0;
                int O = 0;
                int P = 0;
                int Q = 0;
                int R = 0;
                int S = 0;
                int T = 0;
                int U = 0;
                int V = 0;
                int W = 0;
                int X = 0;
                int Y = 0;
                int Z = 0;


                for (int i = 0; i < s.Length; i++) {
                    if (s[i].Equals('A')) {
                        switch (s[i+1]) {
                            case 'A':
                                A++;
                                break;
                            case 'B':
                                B++;
                                break;
                            case 'C':
                                C++;
                                break;
                            case 'D':
                                D++;
                                break;      
                            case 'E':
                                E++;
                                break;
                            case 'F':
                                F++;
                                break;
                            case 'G':
                                G++;
                                break;
                            case 'H':
                                H++;
                                break;        
                            case 'I':
                                I++;
                                break;
                            case 'J':
                                J++;
                                break;
                            case 'K':
                                K++;
                                break;
                            case 'L':
                                L++;
                                break;      
                            case 'M':
                                M++;
                                break;
                            case 'N':
                                N++;
                                break;
                            case 'O':
                                O++;
                                break;
                            case 'P':
                                P++;
                                break;  
                            case 'Q':
                                Q++;
                                break;
                            case 'R':
                                R++;
                                break;
                            case 'S':
                                S++;
                                break;
                            case 'T':
                                T++;
                                break;      
                            case 'U':
                                U++;
                                break;
                            case 'V':
                                V++;
                                break;
                            case 'W':
                                W++;
                                break;
                            case 'X':
                                X++;
                                break;   
                            case 'Y':
                                Y++;
                                break;
                            case 'Z':
                                Z++;
                                break;                   
                        }
                    }
                }
                
              
            }  catch {
                break;
            }
            
            List<string> list = new List<string>();
            list.AddRange(new[] { $"A{A}", })

            return count;
        }
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

        public static char[] ReadFileByChar(string filename) {
            return File.ReadAllTextAsync(filename).Result.ToCharArray();
        }

        public static string Solve2(string filename) {
            List<int> buffer = ReadFile(filename);

            List<(int, int)> pairs = new List<(int, int)>();

            for (int i = 0; i < buffer.Count; i++) {
                for (int j = i + 1; j < buffer.Count; j++) {
                    if (i == j) continue;
                    if ((buffer[i] % 160 == buffer[j] % 160) || (((buffer[i] % 7) != 0) && (buffer[j] % 7) != 0)) continue;
                    else {
                        pairs.Add((buffer[i], buffer[j]));
                    }
                }
            }

            return $"{pairs.Count} {CalculateSums(pairs)}";
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
                        pairs.Add((buffer[i], buffer[j]));
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
                        pairs.Add((buffer[i], buffer[j]));
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
                        pairs.Add((buffer[i], buffer[j]));
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
