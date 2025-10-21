using System;

public class Range
{
    private double start;
    private double end;

    
    public double Start
    {
        get { return start; }
        set
        {
            if (value > end)
                throw new ArgumentException("Начало интервала не может быть больше его конца.");
            start = value;
        }
    }

   
    public double End
    {
        get { return end; }
        set
        {
            if (value < start)
                throw new ArgumentException("Конец интервала не может быть меньше его начала.");
            end = value;
        }
    }

    public Range(double start, double end)
    {
        if (start > end)
            throw new ArgumentException("Начало интервала не может быть больше его конца.");

        this.start = start;
        this.end = end;
    }

    
    public bool IsInside(double x)
    {
        return x >= start && x < end;
    }

    
    public void PrintRange()
    {
        Console.WriteLine($"[{start}, {end})");
    }
}
