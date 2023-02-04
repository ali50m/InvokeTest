namespace InvokeTestLib
{
    public static class Tools
    {
        public static string GetName()
        {
#if NET7_0
            return "Hello from NET7_0";
#else
            return "Hello from other";
#endif
        }
    }
}