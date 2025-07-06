using System.Xml.Schema;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Step 1: create an array of type double of "length" size
        //Step 2: create a loop starting at 1 and repeat until the counter reaches "length"
        //Step 3: multiply the counter by number and store it in the array.
        //  remember to subtract 1 to the counter variable
        //Step 4: return the results

        double[] array = new double[length];

        for (int i = 1; i <= length; i++)
            array[i - 1] = number * i;

        return array; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Step 1: create a List of int called results
        //Step 2: check is amount is larger than data.Count.
        //Step 3: If it is, set amount to data.Count.
        //Step 4: create the i var of type int
        //Step 5: create the j var of type int
        //Step 6: subtract data.Count - amount and store it in j
        //Step 7: create a loop starting at 0 until it reaches data.Count
        //Step 8: copy the first n elements determined by amount and store it in the results list
        //Step 9: restart the index and start copying the rest of the List
        //Step 10: remove all items from data using RemoveRange
        //Step 11: add all items from results in data with InsertRange

        List<int> results = new();

        if (amount > data.Count())
            amount = data.Count();

        int i, j;

        for (i = 0, j = data.Count - amount; i < data.Count(); i++)
        {
            Console.WriteLine("data[{0}]: {1}", j, data[j]);
            results.Add(data[j++]);
            if (j > data.Count - 1)
                j = 0;
        }
        data.RemoveRange(0, data.Count());
        data.InsertRange(0, results);
    }
}
