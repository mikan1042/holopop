using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    private static GameSetting Instance = null;
    public static GameSetting GetInstance()
    {
        if (Instance == null)
            Instance = new GameSetting();

        return Instance;
    }

    public List<GameObject> AvailablePuchiPrefabs { get; private set; }

    string skillName = "Temp_DestroyAll";

    public string GetSkillName() => skillName;
}
