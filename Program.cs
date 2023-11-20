using System.Diagnostics;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Prog2 {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine(NewProgram.ConvertXarySumW1Var("28x2", "93x5", 18, 12, 133));
            Console.WriteLine(NewProgram.ConvertXarySumW1Var("2x84", "2B3x", 19, 16, 88));
        }
        // Макс нечетное, делится на 17
        // Мин нечетное, делится на 17


        // TODO Заучить или запомнить как идиому
        public static int ProcessXarySum(string input1, string input2, int base1, int base2, int div) {
            List<int> operations = new List<int>();

            for (int i = 0; i <= 8; i++) {
                for (int j = 0; j <= 8; j++) {
                    string input1Modified = Regex.Replace(Regex.Replace(input1, "x", i.ToString()), "y", j.ToString());
                    string input2Modified = Regex.Replace(Regex.Replace(input2, "x", i.ToString()), "y", j.ToString());
                    
                    int op1 = FromBase(base1, input1Modified);
                    int op2 = FromBase(base2, input2Modified);

                    int opadd = op1 + op2;
                    int opdiv;

                    if ((opadd % div) == 0) {
                        opdiv = opadd / div;
                        operations.Add(opdiv);
                    }
                }
            }

            return operations.Min();
        }

        public static int FromBase(int @base, string number) {
            ProcessStartInfo info = new ProcessStartInfo();
            
            info.FileName = "./fromBase";
            info.Arguments = $"{number} {@base}";
            info.RedirectStandardOutput = true;

            using Process process = Process.Start(info);
            using StreamReader reader = process.StandardOutput;

            return int.Parse(reader.ReadToEnd().Trim());
        }

        public static int ProcessFile9(string path) {
            string[] rawData = File.ReadAllLines(path);
            List<int> buffer = new List<int>();

            foreach (string i in rawData) {
                buffer.Add(int.Parse(i));
            }

            buffer.Remove(buffer[0]);

            List<(int, int)> pairs = new List<(int, int)>();

            for (int i = 0; i < buffer.Count; i++) {
                for (int j = 0; j < buffer.Count; j++) {
                    if (i != j && (((buffer[i] + buffer[j]) % 80) == 0) && ((buffer[i] > 50) || (buffer[j] > 50))) {
                        Console.WriteLine(buffer[i]);
                        Console.WriteLine(buffer[j]);
                        pairs.Add((buffer[i], buffer[j]));
                    }
                }
            }

            return pairs.Count / 2;
        }


        public static long ProcessFile3(string path) {
            string[] rawData = File.ReadAllLines(path);
            List<int> buffer = new List<int>();

            foreach (string i in rawData) {
                buffer.Add(int.Parse(i));
            }

            long k = buffer[0];
            long n = buffer[1];

            buffer.Remove((int)k);
            buffer.Remove((int)n);
            
            long nmax = 0;
            long kmax = 0;

            for (int i = 0; i < buffer.Count; i++) {
                nmax = Math.Max(nmax, buffer[(int)(i-k)]);
                kmax = Math.Max(kmax, buffer[i] - k);
            }

            return kmax;
        }
        public static int ProcessFile2(string path) {
            string[] rawData = File.ReadAllLines(path);
            List<int> buffer = new List<int>();

            foreach (string i in rawData) {
                buffer.Add(int.Parse(i));
            }

            buffer.Remove(buffer[0]);

            List<(int, int)> pairs = new List<(int, int)>();

            for (int i = 0; i < buffer.Count; i++) {
                for (int j = 0; j < buffer.Count; j++) {
                    if (i == j) continue;
                    else if (i != j && ((buffer[i] * buffer[j] % 62) != 0)) continue;
                    else if (i != j && ((buffer[i] * buffer[j] % 62) == 0)) {
                        pairs.Add((buffer[i], buffer[j]));
                    }
                }
            }

            return pairs.Count / 2;
        }

        static int ProcessFile6(string path) {
            string[] rawData = File.ReadAllLines(path);

            int num = 0;

            List<int> sub = new List<int>();
            List<int> sum = new List<int>();

            for (int i = 1; i < rawData.Length; i++) {
                string[] pair = rawData[i].Split(" ");
                
                int num1 = int.Parse(pair[0]);
                int num2 = int.Parse(pair[1]);

                num = Math.Max(num1, num2);

                sum.Add(num);

                int diff = Math.Abs(num1 - num2);
                if ((diff % 5) != 0) sub.Add(diff);
            }

            sub.Sort();

            int totalsum = sum.Sum();

            if ((totalsum % 5) == 0) {
                return totalsum - sub[0];
            }

            return totalsum;
        }

        public static int ProcessFile5(string path) {
            string[] rawData = File.ReadAllLines(path);
            List<int> buffer = new List<int>();

            foreach (string i in rawData) {
                buffer.Add(int.Parse(i));
            }

            buffer.Remove(buffer[0]);

            List<int> nums = new List<int>();

            for (int i = 0; i < buffer.Count; i++) {
                for (int j = 0; j < buffer.Count; j++) {
                    for (int k = 0; k < buffer.Count; k++) {
                        if (i == k || j == k || i == j) continue;
                        else {
                            int sum = buffer[i] + buffer[j] + buffer[k];

                            if ((sum % 3) == 0) {
                                nums.Add(sum);
                            }
                        }
                    }
                }
            }

            return nums.Max();    
        }

        public static int ProcessFile4(string path) {
            string[] rawData = File.ReadAllLines(path);
            List<int> buffer = new List<int>();

            foreach (string i in rawData) {
                buffer.Add(int.Parse(i));
            }

            buffer.Remove(buffer[0]);

            List<(int, int)> pairs = new List<(int, int)>();

            for (int i = 0; i < buffer.Count; i++) {
                for (int j = 0; j < buffer.Count; j++) {
                    if (i == j) continue;
                    else if (i != j && ((buffer[i] * buffer[j] % 26) != 0)) continue;
                    else if (i != j && ((buffer[i] * buffer[j] % 26) == 0)) {
                        pairs.Add((buffer[i], buffer[j]));
                    }
                }
            }

            return pairs.Count / 2;
        }

        public static (int, int) ProcessFile1(string path) {
            string[] rawData = File.ReadAllLines(path);
            List<int> buffer = new List<int>();

            foreach (string i in rawData) {
                buffer.Add(int.Parse(i));
            }

            buffer.Remove(buffer[0]);
            int maxo17 = 0;
            int maxe17 = 0;
            int maxod = 0;
            int maxev = 0;

            foreach (int i in buffer) {
                if (i > maxo17) {
                    if ((i % 17) == 0 && (i % 2) != 0) {
                        maxo17 = i;
                    }
                }
                if (i > maxe17)  {
                    if ((i % 17) == 0 && (i % 2) == 0) {
                        maxe17 = i;
                    } 
                }
                if (i > maxod) {
                    if ((i % 2) != 0) {
                        maxod = i;
                    } 
                }
                if (i > maxev) {
                    if ((i % 2) == 0) {
                        maxev = i;
                    }
                }
            }

            int sumod = maxo17 + maxod;
            int sumev = maxe17 + maxev;

            if (sumod > sumev) {
                if (maxod > maxo17) {
                    return (maxod, maxo17);
                } else {
                    return (maxo17, maxod);
                }
            } else if (sumev > sumod) {
                if (maxev > maxe17) {
                    return (maxev, maxe17);
                } else {
                    return (maxe17, maxev);
                } 
            }

            return (0, 0);
        }
    }
}