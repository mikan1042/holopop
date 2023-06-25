using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Puchi : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] public Enum.MenberName menber { get; private set; }
    [SerializeField] public Enum.Generation generation { get; private set; }
    public Chain chain;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.TryGetComponent(out Puchi puchi);

        if (puchi == null) return;

        Same(puchi);

    }

    private void Same(Puchi puchi)
    {
        if (this.chain != null && puchi.chain != null)  return;
        if (this.menber != puchi.menber) return;

        if (this.chain == null && puchi.chain == null)
        {
            this.chain = PuchiBox.GetInstance().CreateNewChain(this, puchi);
            puchi.chain = this.chain;
        }
        else
        {
            if (this.chain != null)
            {
                this.chain.AddPuchiToChain(puchi);
                puchi.chain = this.chain;
            }
            else
            {
                puchi.chain.AddPuchiToChain(this);
                this.chain = puchi.chain;
            }
        }
    }
}

