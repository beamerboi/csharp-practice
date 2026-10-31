class Lasagna
{
    public int ExpectedMinutesInOven()
    {
      return 40;  
    }

    public int RemainingMinutesInOven(int spentInOven)
    {
        return ExpectedMinutesInOven() - spentInOven;
    }

    public int PreparationTimeInMinutes(int layer)
    {
        return layer * 2;
    }

    public int ElapsedTimeInMinutes(int layer, int spentInOven)
    {
        return layer * 2 + spentInOven;
    }
}
