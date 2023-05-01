using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbsPuchiFactory<T> : MonoBehaviour
{
    public Puchi Spawn(T type, Transform parent,Vector3 pos)
    {
        Puchi puchi = this.CreatePuchi(type);
        puchi.transform.position = pos;
        puchi.transform.parent = parent;

        return puchi;
    }
    public abstract Puchi CreatePuchi(T type);
}
