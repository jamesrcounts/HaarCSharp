namespace TestHaarCSharp
{
    public abstract class WaveletTransform
    {
        protected const double S0 = 0.5;
        protected const double S1 = 0.5;
        protected const double W0 = 0.5;
        protected const double W1 = -0.5;

        protected WaveletTransform(int iterations)
        {
            Iterations = iterations;
        }

        protected int Iterations { get; private set; }

        public static WaveletTransform CreateTransform(bool forward, int iterations)
        {
            if (forward)
            {
                return new ForwardWaveletTransform(iterations);
            }

            return new InverseWaveletTransform(iterations);
        }

        public abstract void Transform(ColorChannels channels);
    }
}