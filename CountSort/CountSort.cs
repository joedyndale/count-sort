namespace CountSort;

public static class CountSort
{
    public static void SortBytes(byte[] arrayToSort)
    {
        Span<long> counts = stackalloc long[256];
        counts.Clear();

        long lengthOfArrayToStort = arrayToSort.LongLength;
        long arrayToSortIndex = 0L;

        while (arrayToSortIndex < lengthOfArrayToStort)
        {
            counts[arrayToSort[arrayToSortIndex++]]++;
        }

        arrayToSortIndex = 0L;
        ushort countsIndex = 0;

        long valueCount = 0L;
        while (countsIndex < 256)
        {
            while (valueCount < counts[countsIndex])
            {
                arrayToSort[arrayToSortIndex] = (byte)countsIndex;

                valueCount++;
                arrayToSortIndex++;
            }

            valueCount = 0L;
            countsIndex++;
        }
    }

    private static void SortUintsAsBytes(uint[] arrayToSort, uint minValue)
    {
        Span<long> counts = stackalloc long[256];
        counts.Clear();

        long lengthOfArrayToStort = arrayToSort.LongLength;
        long arrayToSortIndex = 0L;

        while (arrayToSortIndex < lengthOfArrayToStort)
        {
            counts[(byte)(arrayToSort[arrayToSortIndex++] - minValue)]++;
        }

        arrayToSortIndex = 0L;
        ushort countsIndex = 0;

        long valueCount = 0L;
        while (countsIndex < 256)
        {
            while (valueCount < counts[countsIndex])
            {
                arrayToSort[arrayToSortIndex] = (uint)(countsIndex + minValue);

                valueCount++;
                arrayToSortIndex++;
            }

            valueCount = 0L;
            countsIndex++;
        }
    }

    public static void SortSbytes(sbyte[] arrayToSort)
    {
        Span<long> counts = stackalloc long[256];
        counts.Clear();

        long lengthOfArrayToStort = arrayToSort.LongLength;
        long arrayToSortIndex = 0L;

        while (arrayToSortIndex < lengthOfArrayToStort)
        {
            counts[(byte)(arrayToSort[arrayToSortIndex++] ^ 0b_1000_0000)]++;
        }

        arrayToSortIndex = 0L;
        ushort countsIndex = 0;

        long valueCount = 0L;
        while (countsIndex < 256)
        {
            while (valueCount < counts[countsIndex])
            {
                arrayToSort[arrayToSortIndex] = (sbyte)(countsIndex ^ 0b_1000_0000);

                valueCount++;
                arrayToSortIndex++;
            }

            valueCount = 0L;
            countsIndex++;
        }
    }

    public static void SortUshorts(ushort[] arrayToSort)
    {
        Thread t = new Thread(() => _SortUshorts(arrayToSort), 600_000);
        t.Start();
        t.Join();
    }

    public static void SortUintsAsUshorts(uint[] arrayToSort, uint minValue)
    {
        Thread t = new Thread(() => _SortUintsAsUshorts(arrayToSort, minValue), 600_000);
        t.Start();
        t.Join();
    }

    private static void _SortUshorts(ushort[] arrayToSort)
    {
        Span<long> counts = stackalloc long[65536];
        counts.Clear();

        long lengthOfArrayToStort = arrayToSort.LongLength;
        long arrayToSortIndex = 0L;

        while (arrayToSortIndex < lengthOfArrayToStort)
        {
            counts[arrayToSort[arrayToSortIndex++]]++;
        }

        arrayToSortIndex = 0L;
        int countsIndex = 0;

        long valueCount = 0L;
        while (countsIndex < 65536)
        {
            while (valueCount < counts[countsIndex])
            {
                arrayToSort[arrayToSortIndex] = (ushort)countsIndex;

                valueCount++;
                arrayToSortIndex++;
            }

            valueCount = 0L;
            countsIndex++;
        }
    }

    private static void _SortUintsAsUshorts(uint[] arrayToSort, uint minValue)
    {
        Span<long> counts = stackalloc long[65536];
        counts.Clear();

        long lengthOfArrayToStort = arrayToSort.LongLength;
        long arrayToSortIndex = 0L;

        while (arrayToSortIndex < lengthOfArrayToStort)
        {
            counts[(ushort)(arrayToSort[arrayToSortIndex++] - minValue)]++;
        }

        arrayToSortIndex = 0L;
        int countsIndex = 0;

        long valueCount = 0L;
        while (countsIndex < 65536)
        {
            while (valueCount < counts[countsIndex])
            {
                arrayToSort[arrayToSortIndex] = (uint)(countsIndex + minValue);

                valueCount++;
                arrayToSortIndex++;
            }

            valueCount = 0L;
            countsIndex++;
        }
    }

    public static void SortShorts(short[] arrayToSort)
    {
        Thread t = new Thread(() => _SortShorts(arrayToSort), 600_000);
        t.Start();
        t.Join();
    }

    private static void _SortShorts(short[] arrayToSort)
    {
        Span<long> counts = stackalloc long[65536];
        counts.Clear();

        long lengthOfArrayToStort = arrayToSort.LongLength;
        long arrayToSortIndex = 0L;

        while (arrayToSortIndex < lengthOfArrayToStort)
        {
            counts[(ushort)(arrayToSort[arrayToSortIndex++] ^ 0b_1000_0000_0000_0000)]++;
        }

        arrayToSortIndex = 0L;
        int countsIndex = 0;

        long valueCount = 0L;
        while (countsIndex < 65536)
        {
            while (valueCount < counts[countsIndex])
            {
                arrayToSort[arrayToSortIndex] = (short)(countsIndex ^ 0b_1000_0000_0000_0000);

                valueCount++;
                arrayToSortIndex++;
            }

            valueCount = 0L;
            countsIndex++;
        }
    }

    public static void SortUints(uint[] arrayToSort)
    {
        long lengthOfArrayToStort = arrayToSort.LongLength;
        long arrayToSortIndex = 0L;

        uint minValue = uint.MaxValue;
        uint maxValue = 0;

        while (arrayToSortIndex < lengthOfArrayToStort)
        {
            if (arrayToSort[arrayToSortIndex] < minValue)
            {
                minValue = arrayToSort[arrayToSortIndex];
            }

            if (arrayToSort[arrayToSortIndex] > maxValue)
            {
                maxValue = arrayToSort[arrayToSortIndex];
            }

            arrayToSortIndex++;
        }

        uint numberRange = maxValue - minValue;
        if (numberRange > 65535)
        {
            Array.Sort(arrayToSort);
        }
        else if (numberRange > 255 && numberRange < 65536)
        {
            SortUintsAsUshorts(arrayToSort, minValue);
        }
        else
        {
            SortUintsAsBytes(arrayToSort, minValue);
        }
    }
}