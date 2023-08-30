using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SendRandomNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            GetRandomNumbers getRandomNumbers = new GetRandomNumbers();
            getRandomNumbers.GetRandomList();
        }
    }
}