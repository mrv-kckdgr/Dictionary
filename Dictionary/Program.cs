using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> customerInformation = new MyDictionary<string, string>();
            customerInformation.Add("names", "Merve");
            customerInformation.Add("surnames", "KÜÇÜKDOĞRU");
            customerInformation.Add("job", "Computer Engineer");

            customerInformation.List();
        }
    }
}
