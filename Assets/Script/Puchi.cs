using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using Holopop.Enum;


[System.Serializable]
public struct PuchiStat
{
    public uint score;
    public uint gold;
    public Generation generation;
    public MemberName member;
}

public class Puchi : MonoBehaviour
{
    public Chain chain;
    public PuchiStat stat;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent(out Puchi another))
        {
            if (IsSame(another))
            {
                if (this.chain == null && another.chain == null)
                    PuchiBox.GetInstance().CreateNewChain(this, another);
                else if (this.chain != null)
                    chain.AddPuchiToChain(another);
                else
                    another.chain.AddPuchiToChain(this);
            }
        }
    }

    private bool IsSame(Puchi another)
    {
        return this.stat.member == another.stat.member;
    }
}

