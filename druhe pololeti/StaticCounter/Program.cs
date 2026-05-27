class Counter
{
    private static int _count = 0;
    private int GetCount()
    {
        return _count;
    }

    public static void add()
    {
        _count++;
    }
}