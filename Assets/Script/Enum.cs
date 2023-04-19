using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{
    public enum GameState
    {
        Ready,
        Start,
        BonusBoom,
        Over
    }
    public enum Menber
    {
        TokinoSora,
        Roboco,
        AZKi,
        SakuraMiko,
        HoshimachiSuisei,
    }

    public enum Generation
    { 
        a,          // 0기생
        b,          // 1기생
        c,          // 2기생
        Fantasy,    // 3기생
        Force,      // 4기생
        Five,       // 5기생
        HoloX,      // 6기생
        Gamers,     // 게이머즈
    }



}
