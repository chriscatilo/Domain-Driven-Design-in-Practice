namespace DddInPractice.Logic
{
    public class Money
    {
        public int OneCentCount { get; private set; }
        public int TwoCentCount { get; private set; }
        public int QuarterCount { get; private set; }
        public int OneDollarCount { get; private set; }
        public int FiveDollarCount { get; private set; }
        public int TwentyDollarCount { get; private set; }

        public Money(
            int oneCentCount,
            int twoCentCount,
            int quarterCount,
            int oneDollarCount,
            int fiveDollarCount,
            int twentyDollarCount
            )
        {
            OneCentCount = oneCentCount;
            TwoCentCount = twoCentCount;
            QuarterCount = quarterCount;
            OneDollarCount = oneDollarCount;
            FiveDollarCount = fiveDollarCount;
            TwentyDollarCount = twentyDollarCount;
        }

        public static Money operator +(Money money1, Money money2)
        {
            var sum = new Money( 
                money1.OneCentCount + money2.OneCentCount,
                money1.TwoCentCount + money2.TwoCentCount,
                money1.QuarterCount + money2.QuarterCount,
                money1.OneDollarCount + money2.OneDollarCount,
                money1.FiveDollarCount + money2.FiveDollarCount,
                money1.TwentyDollarCount + money2.TwentyDollarCount
                );

            return sum;
        }
    }
}
