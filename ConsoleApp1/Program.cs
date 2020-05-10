using System;

namespace ConsoleApp1
{
    class Program
    {
        public enum typeTraine { skTrain, pasTrain, tTrain };
         struct Train
        {
            public string number;
            public string message;
            public int count;
            public readonly typeTraine type;
            public Train(string num, string mes, int c, string traine)
            {
                number = num;
                message = mes;
                count = c;
                this.type = (typeTraine)Enum.Parse(typeof(typeTraine), traine);
            }
            public override string ToString()
            {
                return "Train: " + number + " " + message + " " + count + " " + type;
            }
        }
        static void Main(string[] args)
        {
            // Часть первая
            //первое и второе
            Train a1 = new Train("a1", "Hello", 12, "skTrain");
            Console.WriteLine(a1);
            //третье задание
            bool flag = false;
            SByte a = 0;
            Byte b = 0;
            Int16 c = 0;
            Int64 d = 0;
            String s = "";
            Exception ex = new Exception();
            Object[] types = { a, b, c, d, s, ex};
            foreach (object o in types)
            {
                Type t = o.GetType();
                flag = t.IsValueType;
                Console.WriteLine("{0} is a value type: {1}", t.FullName, flag);
            }
            // четвертое задание
            String str1 = "HgggF HJassssss HJ";
            String str2 = "";
            string[] sa = str1.Split();
            Array.Sort(sa);
            foreach (string st in sa)
            {
                Console.Write("{0};",st);
            }
            Console.WriteLine();
            str2 =  String.Join("..", sa);
            Console.WriteLine(str2);

        }
    }
}
