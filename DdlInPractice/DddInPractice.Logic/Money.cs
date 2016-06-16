﻿namespace DddInPractice.Logic
{
    public class Money : ValueObject<Money>
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

        protected override bool EqualsCore(Money other)
        {
            return base.Equals(other) && 
                OneCentCount == other.OneCentCount && 
                TwoCentCount == other.TwoCentCount &&
                QuarterCount == other.QuarterCount && 
                OneDollarCount == other.OneDollarCount &&
                FiveDollarCount == other.FiveDollarCount && 
                TwentyDollarCount == other.TwentyDollarCount;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = OneCentCount;
                hashCode = (hashCode * 397) ^ TwoCentCount;
                hashCode = (hashCode * 397) ^ QuarterCount;
                hashCode = (hashCode * 397) ^ OneDollarCount;
                hashCode = (hashCode * 397) ^ FiveDollarCount;
                hashCode = (hashCode * 397) ^ TwentyDollarCount;
                return hashCode;
            }
        }
    }
}
