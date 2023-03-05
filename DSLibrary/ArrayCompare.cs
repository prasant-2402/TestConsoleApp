using System.Reflection.Metadata.Ecma335;

namespace DSLibrary
{
    public class ArrayCompare<T>
    {
        T[] firstArray;
        T[] secondArray;

        public T[] FirstArray { get => firstArray; set=> firstArray = value; }
        public T[] SecondArray { get => secondArray; set=> secondArray = value; }

        public bool IsSameArray ()
        {
            return firstArray.SequenceEqual (secondArray);
        }
    }
}