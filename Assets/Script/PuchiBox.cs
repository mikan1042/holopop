using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuchiBox : MonoBehaviour
{
    List<Puchi> puchiList = new();
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        FillPuchi();
    }
    private void FillPuchi()
    {
        if(puchiList.Count < 40)
        {

        }
    }
}
