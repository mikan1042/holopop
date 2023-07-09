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
    [SerializeField] private MainGameTimer gametimer;
    [SerializeField] private Enum.GameState gameState;

    private void Awake() => Instance = this;
    private void Start() => GameStart();

    public void ChangeState(Enum.GameState state)
    {
        gameState = state;

        switch (state)
        {
            case Enum.GameState.Ready:
                break;
            case Enum.GameState.Start:
                gametimer.isUpdating = true;
                break;
            case Enum.GameState.BonusBoom:
                break;
            case Enum.GameState.Over:
                break;
        }
    }

    private void GameStart()
    {
        ChangeState(Enum.GameState.Start);
    }
}
