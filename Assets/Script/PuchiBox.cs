using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuchiBox : MonoBehaviour
{
    /// ** ΩÃ±€≈Ê ** /// 
    private static PuchiBox Instance = null;
    public static PuchiBox GetInstance()
    {
        if (Instance == null)
            Instance = new PuchiBox();

        return Instance;
    }
    // ** ΩÃ±€≈Ê ** ///


    const int MAXPUCHI = 40;
    public List<Puchi> puchiList { get; private set; } = new();
    public List<Chain> puchiChainList { get; private set; } = new();
    [SerializeField] private PuchiFactory puchiFactory = null;
    [SerializeField] private GameObject BOX = null;
    [SerializeField] private GameObject spawnPoint = null;

    void Update()
    {
        FillPuchi();
    }

    private void FillPuchi()
    {
        if(puchiList.Count < MAXPUCHI)
        {
            int randomType = Random.Range(0, 5);
            puchiList.Add(this.puchiFactory.Spawn((Enum.MenberName)randomType, BOX.transform,spawnPoint.transform.position));
        }
    }

    public Chain CreateNewChain(Puchi puchiA, Puchi puchiB)
    {
        Chain chain = new Chain();
        chain.AddPuchiToChain(puchiA);
        chain.AddPuchiToChain(puchiB);

        puchiChainList.Add(chain);

        return chain;
    }
}
