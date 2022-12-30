namespace GameConsole
{
    public abstract class SpecialDefence
    {
        public abstract int CalculateDamageReduction();

        public static SpecialDefence Null { get; } = new NullDefence();

        private class NullDefence : SpecialDefence
        {
            public override int CalculateDamageReduction()
            {
                return 0; // "no op" or "do nothing" behavior
            }
        }
    }
}