namespace Prog2 {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine(ProcessFile2("27990_A.txt"));
            Console.WriteLine(ProcessFile2("27990_B.txt"));
        }
        // Макс нечетное, делится на 17
        // Мин нечетное, делится на 17

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