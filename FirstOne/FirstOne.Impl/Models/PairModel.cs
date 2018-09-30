namespace FirstOne.Impl.Models
{
    public class PairModel
    {
        public PairModel(int firstElementIndex, int secondElementIndex)
        {
            FirstElementIndex = firstElementIndex;
            SecondElementIndex = secondElementIndex;
        }

        public int FirstElementIndex { get; }
        public int SecondElementIndex { get; }

        public override string ToString()
        {
            return
                $"{nameof(FirstElementIndex)}: {FirstElementIndex}, {nameof(SecondElementIndex)}: {SecondElementIndex};";
        }
    }
}