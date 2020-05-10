using System;

namespace ConsoleApp2
{
    class Program
    {   // 2.1
        public enum typeTraine { skTrain, pasTrain, tTrain };
        class Train
        {
            public string number;
            public string message;
            public int count;
            public typeTraine type;
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
        class FirmTrain : Train
        {
            public string nameFirm;
            public int kPrice;
            public FirmTrain(string num, string mes, int c, string traine, string name, int k) : base( num,  mes,  c,  traine)
            {
                number = num;
                message = mes;
                count = c;
                this.type = (typeTraine)Enum.Parse(typeof(typeTraine), traine);
                nameFirm = name;
                kPrice = k;
            }
            public override string ToString()
            {
                
                return base.ToString() + " " + nameFirm + " " + kPrice;
            }
        }
        //2 . 2
        interface IDisposable
        {
            void method();
        }

        class BigClass : IDisposable
        {
            public void method()
            {
                Console.WriteLine("method");
            }
        }


        static void Main(string[] args)
        {
            FirmTrain a1 = new FirmTrain("a1", "Hello", 12, "skTrain","Rails",10);
            Console.WriteLine(a1);
            //2.4
            Int16 i16 = 2;
            Int32 i32 = 24214;
            Int64 i64 = 2341222;

            //i16 = i32; // нельзя
            //i32 = i64; // нельзя

            // i32 = i16; 
            // i64 = i32;

            //i16 = i64; // нельзя
            //i64 = i16;
        }
    }
}
