public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var res = new int[select.Length];
        int i, a1, a2;
        for (i = a1 = a2 = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
                res[i] = list1[a1++];
            else
                res[i] = list2[a2++];
        }
        return res;
    }
}