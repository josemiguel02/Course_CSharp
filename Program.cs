using System.Threading.Tasks;
using Course_CSharp._07_Asynchronism;

namespace Course_CSharp;

class Program
{
    public static async Task Main(string[] args)
    {
        await TaskClass.CrearTarea();
    }
}