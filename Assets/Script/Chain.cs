using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain
{
    public List<Puchi> puchis = new List<Puchi>();
    public void AddPuchiToChain(Puchi x)
    {
        x.chain = this;
        puchis.Add(x);
    }
}
