using System;

public static class CollectionUtilities
{
    /// <summary>
    /// Shuffles randomly elements of the array
    /// </summary>
    /// <param name="array">array to shuffle</param>
    public static void Shuffle<T>(this Random rnd, T[] array)
    {
        int n = array.Length;
        while (n > 1)
        {
            int k = rnd.Next(n--);
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }
}
