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
    public enum MenberName
    {
        TokinoSora,
        Roboco,
        AZKI,
        SakuraMiko,
        HoshimachiSuisei,
    }

    public enum Generation
    {
        a,          // 0���
        b,          // 1���
        c,          // 2���
        Fantasy,    // 3���
        Force,      // 4���
        Five,       // 5���
        HoloX,      // 6���
        Gamers,     // ���̸���
    }
}

namespace Holopop.Enum
{
    public enum MemberName
    {
        AZKI,
        Chika,
        HoshimachiSuisei,
        Roboco,
        SakuraMiko,
        TokinoSora,
    }

    public enum Generation
    {
        a,          // 0���
        b,          // 1���
        c,          // 2���
        Fantasy,    // 3���
        Force,      // 4���
        Five,       // 5���
        HoloX,      // 6���
        Gamers,     // ���̸���
    }
}