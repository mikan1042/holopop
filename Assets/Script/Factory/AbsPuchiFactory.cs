using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbsPuchiFactory<T> : MonoBehaviour
{
    public Puchi Spawn(T type, Transform parent)
    {
        Puchi puchi = this.CreatePuchi(type);
        puchi.transform.parent = parent;

        return puchi;
    }
    public abstract Puchi CreatePuchi(T type);
}
