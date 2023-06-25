using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
   public List<Puchi> puchis = new List<Puchi>();
    public void AddPuchiToChain(Puchi puchi)
    {
        puchis.Add(puchi);
    }
}
