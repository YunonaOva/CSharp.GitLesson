using System;

namespace BinarySearch;

/// <summary>
/// Двоичный поиск в отсортированном массиве.
/// </summary>
public static class BinarySearch
{
    /// <summary>
    /// Искать число <see cref="x"/> массиве целочисленных чисел.
    /// </summary>
    /// <param name="array">Массив целочисленных чисел.</param>
    /// <param name="x">Искомый элемент.</param>
    /// <returns>Индекс <see cref="x"/> в массиве. Иначе <c>-1</c>, если элемент не найден.</returns>
    public static int Search(int[] array, int x)
    {
        // Здесь нужно реализовать поиск.
       
        int left = 0;
        int right = array.Length -1;
        int middle = (left + right) / 2;

        while (true)
        {
        if (left > right)
            break;

        if (x == array[middle])
            return middle;
        if (x > array[middle])
            left = middle + 1;
        if (x < array[middle])
             right = middle;
        }

        return -1;
    }
}