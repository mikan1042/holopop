using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ** ΩÃ±€≈Ê ** // 
    private static GameManager Instance = null;
    public static GameManager GetInstance()
    {
        if (Instance == null)
            Instance = new GameManager();

        return Instance;
    }
    // ** ΩÃ±€≈Ê ** // 

    private int score;
    private int gold;
    private Enum.GameState gameState = Enum.GameState.Ready;

    private void Start()
    {
        ChangeState(Enum.GameState.Start);
    }
    private void Update()
    {
        
    }

    public void ChangeState(Enum.GameState state)
    {
        gameState = state;

        switch (state)
        {
            case Enum.GameState.Ready:
                break;
            case Enum.GameState.Start:
                break;
            case Enum.GameState.BonusBoom:
                break;
            case Enum.GameState.Over:
                break;
        }
    }


}
