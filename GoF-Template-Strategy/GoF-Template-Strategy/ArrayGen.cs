using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Template_Strategy
{
    public abstract class ArrayGenerator
    {
        protected int Size { get;  }
        int Seed { get; }

        protected ArrayGenerator(int size, int seed)
        {
            Size = size;
            Seed = seed;
        }

        public int[] NewArray()
        {
            return GenerateArray(Init());
        }

         protected Random Init()
         {
            return new Random(Seed);
        }
         protected abstract int[] GenerateArray(Random gen);
    }

    public class RandomArrayGenerator : ArrayGenerator
    {
        public RandomArrayGenerator(int size, int seed) : base(size, seed)
        {
            
        }

        protected override int[] GenerateArray(Random gen)
        {
            var randomArray = new int[Size];
            for (var i = 0; i < Size; i++)
            {
                randomArray[i] = gen.Next(0,Size);
            }
            return randomArray;
        }
    }

    public class NearlySortedArray : ArrayGenerator
    {
        public NearlySortedArray(int size, int seed) : base(size, seed)
        {
        }

        protected override int[] GenerateArray(Random gen)
        {
            var nearlySortedArray = new int[Size];
            for (var i = 1; i < Size; i++)
            {
                nearlySortedArray[i-1] = i;

                if (Size / i == Size / 8) nearlySortedArray[i - 1] = gen.Next(0, Size);
                if (Size / i == Size / 4) nearlySortedArray[i - 1] = gen.Next(0, Size);
                if (Size / i == Size / 2) nearlySortedArray[i - 1] = gen.Next(0, Size);

            }
            return nearlySortedArray;
        }
    }

    public class ReverseRandomArray : ArrayGenerator
    {
        public ReverseRandomArray(int size, int seed) : base(size, seed)
        {
        }

        protected override int[] GenerateArray(Random gen)
        {
            var randomArray = new int[Size];
            for (var i = Size; i >= 0; i--)
            {
                randomArray[i] = gen.Next(0, Size);
            }
            return randomArray;
        }
    }

    public class ReverseOrderArray : ArrayGenerator
    {
        public ReverseOrderArray(int size, int seed) : base(size, seed)
        {
        }

        protected override int[] GenerateArray(Random gen)
        {
            var reverseArray = new int[Size];
            for (var i = Size; i >= 0; i--)
            {
                reverseArray[i] = i;
            }
            return reverseArray;
        }
    }

    public class FewUniqueArray : ArrayGenerator
    {
        public FewUniqueArray(int size, int seed) : base(size, seed)
        {
        }

        protected override int[] GenerateArray(Random gen)
        {
            var fewArray = new int[Size];
            var unique = new int[Size/8];

            for (var i = 0; i < Size/8; i++)
            {
                unique[i] = i;
            }

            for (var i = 0; i < Size; i++)
            {
                fewArray[i] = unique[gen.Next(0, unique.Count())];
            }

            return fewArray;
        }
    }
}
