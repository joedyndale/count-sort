namespace CountSort.Tests;

public class Tests
{
    [Test]
    public void TestSmallByteArray()
    {
        byte[] arrayToSort = new byte[] { 3, 0, 5, 255, 137, 42 };

        CountSort.SortBytes(arrayToSort);

        Assert.That(new byte[] { 0, 3, 5, 42, 137, 255 }, Is.EqualTo(arrayToSort));
    }

    [Test]
    public void TestLargeByteArray()
    {
        byte[] arrayToSort = new byte[10_000_000];
        var r = new Random();
        r.NextBytes(arrayToSort);

        var baseline = new byte[10_000_000];
        Array.Copy(arrayToSort, baseline, arrayToSort.Length);

        CountSort.SortBytes(arrayToSort);
        Array.Sort(baseline);

        for (int i = 0; i < 10_000_000; i++)
        {
            Assert.That(arrayToSort[i], Is.EqualTo(baseline[i]));
        }
    }

    [Test]
    public void TestSmallSbyteArray()
    {
        sbyte[] arrayToSort = new sbyte[] { 3, 0, 5, -37, 127, -128 };

        CountSort.SortSbytes(arrayToSort);

        Assert.That(new sbyte[] { -128, -37, 0, 3, 5, 127 }, Is.EqualTo(arrayToSort));
    }

    [Test]
    public void TestLargeSbyteArray()
    {
        sbyte[] arrayToSort = new sbyte[10_000_000];
        var r = new Random();

        for (int i = 0; i < arrayToSort.Length; i++)
        {
            arrayToSort[i] = (sbyte)r.Next(-128, 128);
        }

        var baseline = new sbyte[10_000_000];
        Array.Copy(arrayToSort, baseline, arrayToSort.Length);

        CountSort.SortSbytes(arrayToSort);
        Array.Sort(baseline);

        for (int i = 0; i < 10_000_000; i++)
        {
            Assert.That(arrayToSort[i], Is.EqualTo(baseline[i]));
        }
    }

    [Test]
    public void TestSmallUshortArray()
    {
        ushort[] arrayToSort = new ushort[] { 3, 0, 5, 255, 137, 42 };

        CountSort.SortUshorts(arrayToSort);

        Assert.That(new ushort[] { 0, 3, 5, 42, 137, 255 }, Is.EqualTo(arrayToSort));
    }

    [Test]
    public void TestLargeUshortArray()
    {
        ushort[] arrayToSort = new ushort[10_000_000];
        var r = new Random();

        for (int i = 0; i < arrayToSort.Length; i++)
        {
            arrayToSort[i] = (ushort)r.Next(0, 65536);
        }

        var baseline = new ushort[10_000_000];
        Array.Copy(arrayToSort, baseline, arrayToSort.Length);

        CountSort.SortUshorts(arrayToSort);
        Array.Sort(baseline);

        for (int i = 0; i < 10_000_000; i++)
        {
            Assert.That(arrayToSort[i], Is.EqualTo(baseline[i]));
        }
    }

    [Test]
    public void TestSmallShortArray()
    {
        short[] arrayToSort = new short[] { 3, 0, 5, -37, 127, -128 };

        CountSort.SortShorts(arrayToSort);

        Assert.That(new short[] { -128, -37, 0, 3, 5, 127 }, Is.EqualTo(arrayToSort));
    }

    [Test]
    public void TestLargeShortArray()
    {
        short[] arrayToSort = new short[10_000_000];
        var r = new Random();

        for (int i = 0; i < arrayToSort.Length; i++)
        {
            arrayToSort[i] = (short)r.Next(-32768, 32768);
        }

        var baseline = new short[10_000_000];
        Array.Copy(arrayToSort, baseline, arrayToSort.Length);

        CountSort.SortShorts(arrayToSort);
        Array.Sort(baseline);

        for (int i = 0; i < 10_000_000; i++)
        {
            Assert.That(arrayToSort[i], Is.EqualTo(baseline[i]));
        }
    }

    [Test]
    public void TestSmallUintArray()
    {
        uint[] arrayToSort = new uint[] { 3, 0, 5, 37, 127, 34567 };

        CountSort.SortUints(arrayToSort);

        Assert.That(new uint[] { 0, 3, 5, 37, 127, 34567 }, Is.EqualTo(arrayToSort));
    }

    [Test]
    public void TestLargeUintArray()
    {
        uint[] arrayToSort = new uint[10_000_000];
        var r = new Random();

        for (int i = 0; i < arrayToSort.Length; i++)
        {
            arrayToSort[i] = (uint)r.NextInt64(0, 4_294_967_296);
        }

        var baseline = new uint[10_000_000];
        Array.Copy(arrayToSort, baseline, arrayToSort.Length);

        CountSort.SortUints(arrayToSort);
        Array.Sort(baseline);

        for (int i = 0; i < 10_000_000; i++)
        {
            Assert.That(arrayToSort[i], Is.EqualTo(baseline[i]));
        }
    }

    [Test]
    public void TestLargeUintArraysWithDifferentRanges()
    {
        uint[] arrayToSort_ByteRange = new uint[10_000_000];
        uint[] arrayToSort_UShortRange = new uint[10_000_000];
        var r = new Random();

        for (int i = 0; i < arrayToSort_ByteRange.Length; i++)
        {
            arrayToSort_ByteRange[i] = (uint)r.NextInt64(1_234_567, 1_234_567 + 256);
        }

        for (int i = 0; i < arrayToSort_UShortRange.Length; i++)
        {
            arrayToSort_UShortRange[i] = (uint)r.NextInt64(1_234_567, 1_234_567 + 65536);
        }

        var baseline = new uint[10_000_000];
        Array.Copy(arrayToSort_ByteRange, baseline, arrayToSort_ByteRange.Length);

        CountSort.SortUints(arrayToSort_ByteRange);
        Array.Sort(baseline);

        for (int i = 0; i < 10_000_000; i++)
        {
            Assert.That(arrayToSort_ByteRange[i], Is.EqualTo(baseline[i]));
        }

        baseline = new uint[10_000_000];
        Array.Copy(arrayToSort_UShortRange, baseline, arrayToSort_UShortRange.Length);

        CountSort.SortUints(arrayToSort_UShortRange);
        Array.Sort(baseline);

        for (int i = 0; i < 10_000_000; i++)
        {
            Assert.That(arrayToSort_UShortRange[i], Is.EqualTo(baseline[i]));
        }
    }
}