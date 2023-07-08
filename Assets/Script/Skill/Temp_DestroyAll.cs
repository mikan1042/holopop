using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.VersionControl;
using UnityEngine;

public class Temp_DestroyAll : BaseSkill
{
    public override void Prepare()
    {
        base.Prepare();
    }
    public override void Execute()
    {
        base.Execute();

        var puchiBox = PuchiBox.GetInstance();

        for (int i = 0; i < puchiBox.ChainSet.Count; i++)
        {
            if (i == -1) return;

            Chain chain = puchiBox.ChainSet.ElementAt(i);

            puchiBox.DestroyChain(chain);

            i--;
        }

        for (int i = 0; i < puchiBox.PuchiSet.Count; i++)
        {
            if (i == -1) return;

            Puchi puchi = puchiBox.PuchiSet.ElementAt(i);

            puchiBox.PuchiSet.Remove(puchi);
            Destroy(puchi.gameObject);

            i--;
        }
    }
}
