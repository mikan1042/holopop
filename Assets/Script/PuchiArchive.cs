using UnityEngine;
using System.Collections.Generic;

public class PuchiArchive
{
    GoldCalculator goldCalc;
    ScoreCalculator scoreCalc;

    public List<PuchiStat> archives;

    public void Archive(Chain c)
    {
        foreach (var p in c.puchis)
        {
            goldCalc.Calc(p.stat);
            scoreCalc.Calc(p.stat);
            archives.Add(p.stat);
        }
    }
}

public class GoldCalculator
{
    public int AccGold = 0;

    public void Calc(PuchiStat p)
    {
        AccGold += (int)p.gold;
    }
}

public class ScoreCalculator
{
    public int AccScore = 0;

    public void Calc(PuchiStat p)
    {
        AccScore += (int)p.score;
    }
}