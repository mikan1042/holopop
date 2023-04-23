using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuchiBox : MonoBehaviour
{
    const int MAXPUCHI = 40;
    List<Puchi> puchiList = new();
    [SerializeField] private PuchiFactory puchiFactory = null;
    [SerializeField] private GameObject BOX = null;

    void Start()
    {

    }

    void Update()
    {
        FillPuchi();
    }

    private void FillPuchi()
    {
        if(puchiList.Count < MAXPUCHI)
        {
            int randomType = Random.Range(0, 5);
            puchiList.Add(this.puchiFactory.Spawn((Enum.MenberName)randomType, BOX.transform));
        }
    }
}
