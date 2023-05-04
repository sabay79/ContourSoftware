namespace WorkWithLINQ
{
    // An extension method is a special purpose static method that adds new functionality to an already-existing type without having to modify the original type you want to add functionality to.
    public static class Extensions
    {
        public static IEnumerable<T> InterleaveSequenceWith<T>
            (this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIteration = first.GetEnumerator();
            var secondIteration = second.GetEnumerator();

            while (firstIteration.MoveNext() && secondIteration.MoveNext())
            {
                yield return firstIteration.Current;
                yield return secondIteration.Current;
            }
        }
        public static bool SequenceEquals<T>
            (this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIteration = first.GetEnumerator();
            var secondIteration = second.GetEnumerator();

            while ((firstIteration?.MoveNext() == true) && secondIteration.MoveNext())
            {
                if ((firstIteration.Current is not null) && !firstIteration.Current.Equals(secondIteration.Current))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
