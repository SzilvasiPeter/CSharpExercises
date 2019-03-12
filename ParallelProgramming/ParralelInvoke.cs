using System;
using System.Threading.Tasks;
using System.Net;
using System.Linq;

namespace ParallelProgramming
{
    public class ParralelInvoke
    {
        // static void Main(string[] args)
        // {
        //     WebClient wc = new WebClient();

        //     string[] s = wc.DownloadString("http://www.gutenberg.org/cache/epub/103/pg103.txt")
        //         .Split(
        //             new char[] {' ', '\u000A', ',', '.', ';', ':', '-', '_', '/'},
        //             StringSplitOptions.RemoveEmptyEntries
        //         );
            
        //     Parallel.Invoke(
        //         () => System.Console.WriteLine(s.OrderByDescending((item) => item.Length).First()),
        //         () => System.Console.WriteLine(s.Length)
        //     );
        // }
    }
}