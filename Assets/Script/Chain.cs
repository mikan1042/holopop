using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain
{
    public HashSet<Puchi> puchis = new HashSet<Puchi>();
    public void AddPuchiToChain(Puchi x)
    {
        x.chain = this;
        puchis.Add(x);
    }
}
