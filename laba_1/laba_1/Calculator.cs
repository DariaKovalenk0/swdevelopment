using System;

public class Calculator
{
    private readonly ILogger _logger;

    public Calculator(ILogger logger)
    {
        _logger = logger;
    }

    public double Der_tg(double x)
    {
        var result = 1 / Math.Pow(Math.Cos(x), 2);
        _logger.Log(result);
        return result;
    }

    public double Der_ln(double x)
    {
        var result = 1 / x;
        _logger.Log(result);
        return result;
    }

    public double Der_exp(double x)
    {
        var result = Math.Exp(x);
        _logger.Log(result);
        return result;
    }
}
