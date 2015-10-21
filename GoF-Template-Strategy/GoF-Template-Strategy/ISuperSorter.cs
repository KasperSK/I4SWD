using System;
using System.Diagnostics;

namespace GoF_Template_Strategy
{
    public interface ISuperSorter
    {
        int[] Sort(int[] toSort);
        double ElapsedTime { get; }
  
    }


    public class BubbleSort : ISuperSorter
    {
        public int[] Sort(int[] toSort)
        {
            int[] sorted = new int[toSort.Length];
            Array.Copy(toSort, sorted, toSort.Length);
            _timer.Reset();
            _timer.Start();
            int i, j;
            int N = sorted.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (sorted[i] > sorted[i + 1])
                        Exchange(sorted, i, i + 1);
                }
            }
            _timer.Stop();
            ElapsedTime = _timer.ElapsedMilliseconds;
            return sorted;
        }

        public double ElapsedTime { get; private set; }

        private readonly Stopwatch _timer = new Stopwatch();

        public static void Exchange(int[] data, int m, int n)
        {
            var temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
    }

    public class InsertionSort : ISuperSorter
    {
        public int[] Sort(int[] toSort)
        {
            int[] sorted = new int[toSort.Length];
            Array.Copy(toSort, sorted, toSort.Length);
            _timer.Reset();
            _timer.Start();
            int i, j;
            int N = sorted.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && sorted[i] < sorted[i - 1]; i--)
                {
                    Exchange(sorted, i, i - 1);
                }
            }
            _timer.Stop();
            ElapsedTime = _timer.ElapsedMilliseconds;
            return sorted;
        }

        public double ElapsedTime { get; private set; }
        private readonly Stopwatch _timer = new Stopwatch();

        public static void Exchange(int[] data, int m, int n)
        {
            var temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
    }
    
    public class ShellSort : ISuperSorter
    {
        public int[] Sort(int[] toSort)
        {
            int[] sorted = new int[toSort.Length];
            Array.Copy(toSort, sorted, toSort.Length);

            _timer.Reset();
            _timer.Start();
            int[] intervals = { 1, 2, 4, 8 };
            IntArrayShellSort(sorted, intervals);
            _timer.Stop();
            ElapsedTime = _timer.ElapsedMilliseconds;
            return sorted;
        }

        public double ElapsedTime { get; private set; }
        private readonly Stopwatch _timer = new Stopwatch();

        private void IntArrayShellSort(int[] data, int[] intervals)
        {
            int i, j, k, m;
            int N = data.Length;

            // The intervals for the shell sort must be sorted, ascending

            for (k = intervals.Length - 1; k >= 0; k--)
            {
                int interval = intervals[k];
                for (m = 0; m < interval; m++)
                {
                    for (j = m + interval; j < N; j += interval)
                    {
                        for (i = j; i >= interval && data[i] < data[i - interval]; i -= interval)
                        {
                            Exchange(data, i, i - interval);
                        }
                    }
                }
            }
        }
        public static void Exchange(int[] data, int m, int n)
        {
            var temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
    }

    public class QuickSort : ISuperSorter
    {
        public int[] Sort(int[] toSort)
        {
            int[] sorted = new int[toSort.Length];
            Array.Copy(toSort, sorted, toSort.Length);
            _timer.Reset();
            _timer.Start();
            IntArrayQuickSort(sorted, 0, sorted.Length - 1);
            _timer.Stop();
            ElapsedTime = _timer.ElapsedMilliseconds;
            return sorted;
        }

        public double ElapsedTime { get; private set; }
        private readonly Stopwatch _timer = new Stopwatch();

        public static void IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    Exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }
        public static void Exchange(int[] data, int m, int n)
        {
            var temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
    }


}


