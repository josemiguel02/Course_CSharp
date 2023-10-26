using System.Threading.Tasks;
using Course_CSharp._08_Exceptions;

namespace Course_CSharp;

class Program
{
    public static async Task Main(string[] args)
    {
        new CustomException();
    }
}