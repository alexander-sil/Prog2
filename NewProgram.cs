using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Prog2 {
    class NewProgram {
        public static int ConvertXarySumW1Var(string input1, string input2, int base1, int base2, int div) {
            List<int> res = new List<int>();
            int @baseMin = base1 < base2 ? base1 : base2;
            int @baseMax = base1 > base2 ? base1 : base2;
            for (int i = 0; i <= @baseMin - 1; i++) {
                string input1Modified = Regex.Replace(input1, "x", Convert.ToString(i));
                string input2Modified = Regex.Replace(input2, "x", Convert.ToString(i));

                int num1 = FromBase(input1Modified, base1);
                int num2 = FromBase(input2Modified, base2);

                int opadd = num1 + num2;
                int opdiv;

                if ((opadd % div) == 0) {
                    opdiv = opadd / div;
                    res.Add(opdiv);
                }
            }

            return res.Min();
        }

        public static int FromBase(string num, int @base) {
            ProcessStartInfo info = new ProcessStartInfo();

            info.FileName = "./fromBase";
            info.Arguments = $"{num} {@base}";
            info.RedirectStandardOutput = true;

            using Process process = Process.Start(info);
            using StreamReader reader = process.StandardOutput;

            return int.Parse(reader.ReadToEnd().Trim());
        }
    }
}