using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puchi : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] public Enum.MenberName menber { get; private set; }
    [SerializeField] public Enum.Generation generation { get; private set; }
    public bool stick { get; private set; } = false;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.TryGetComponent(out Puchi puchi);
        if (puchi == null) return;

        if (menber == puchi.menber)
        {
            stick = true;
        }
    }

}

