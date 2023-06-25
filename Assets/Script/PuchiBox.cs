using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuchiBox : MonoBehaviour
{
    private static PuchiBox Instance = null;
    public static PuchiBox GetInstance()
    {
        if (Instance == null)
            Instance = new PuchiBox();

        return Instance;
    }

    const int MAXPUCHI = 40;
    public HashSet<Puchi> PuchiSet { get; private set; } = new();
    public HashSet<Chain> ChainSet { get; private set; } = new();
    [SerializeField] private PuchiFactory puchiFactory = null;
    [SerializeField] private GameObject BOX = null;
    [SerializeField] private GameObject spawnPoint = null;

    private float dt = 0f;
    void Update()
    {
        dt += Time.deltaTime;
        if (0.3f <= dt)
        {
            FillPuchi();
            dt = 0f;
        }
    }

    private void FillPuchi()
    {
        if (PuchiSet.Count < MAXPUCHI)
        {
            int randomType = Random.Range(0, 5);
            var offset = Random.insideUnitCircle;
            var pos = spawnPoint.transform.position + new Vector3(offset.x, offset.y, 0);
            PuchiSet.Add(this.puchiFactory.Spawn((Enum.MenberName)randomType, BOX.transform, pos));
        }
    }

    public Chain CreateNewChain(Puchi a, Puchi b)
    {
        Chain chain = new Chain();
        chain.AddPuchiToChain(a);
        chain.AddPuchiToChain(b);

        ChainSet.Add(chain);

        return chain;
    }

    public void DestroyChain(Chain c)
    {
        foreach (var p in c.puchis)
        {
            PuchiSet.Remove(p);
            Destroy(p.gameObject);
        }

        ChainSet.Remove(c);
    }
}
