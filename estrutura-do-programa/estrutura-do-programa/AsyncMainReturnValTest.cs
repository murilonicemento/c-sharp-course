namespace estrutura_do_programa;

public static class AsyncMainReturnValTest
{
    public static void Main()
    {
        AsyncConsoleWork().GetAwaiter().GetResult();
    }

    private static async Task<int> AsyncConsoleWork()
    {
        // Main body here
        return 0;
    }
}

class Program
{
    static async Task<int> Main(string[] args)
    {
        return await AsyncConsoleWork();
    }

    private static async Task<int> AsyncConsoleWork()
    {
        // main body here 
        return 0;
    }
}