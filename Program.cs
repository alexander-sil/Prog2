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
            Console.WriteLine(Solve24_2("24.txt"));
        }

        public static int Solve27_3(string filename) {
            List<int> data = ReadFile(filename);
            List<int> buff = new List<int>();

            data.Remove(data[0]);

            for (int i = 0; i < data.Count; i++) {
                for (int j = 0; j < data.Count; j++) {
                    if (i != j) {
                        buff.Add(data[i] * data[j]);
                    } else continue;
                }
            }

            buff = buff.Where(f => (f % 14) == 0).ToList();

            return buff.Max();
        
        }


        public static int Solve27_4(string filename) {
            List<int> data = ReadFile(filename);
            List<int> buff = new List<int>();

            data.Remove(data[0]);

            for (int i = 0; i < data.Count; i++) {
                for (int j = 0; j < data.Count; j++) {
                    if (i != j) {
                        buff.Add(data[i] * data[j]);
                    } else continue;
                }
            }

            buff = buff.Where(f => (f % 14) == 0).ToList();

            return buff.Max();
        
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
