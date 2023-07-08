using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance = null;
    public static GameManager GetInstance()
    {
        if (Instance == null)
            Instance = new GameManager();

        return Instance;
    }

    private int score;
    private int gold;
    [SerializeField] private Enum.GameState gameState;

    private void Awake()
    {
        Instance = this;
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
