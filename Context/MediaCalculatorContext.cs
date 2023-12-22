using PruebaTecnica.Interface;

public class MediaCalculatorContext
{
    private IMediaCalculator mediaCalculator;

    public void SetMediaCalculator(IMediaCalculator calculator)
    {
        mediaCalculator = calculator;
    }

    public double CalculateMedia(List<double> numbers)
    {
        if (mediaCalculator == null)
        {
            throw new InvalidOperationException("Media calculator is not set.");
        }

        return mediaCalculator.GetMedia(numbers);
    }
}
