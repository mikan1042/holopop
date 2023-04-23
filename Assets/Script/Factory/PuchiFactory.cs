using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuchiFactory : AbsPuchiFactory<Enum.MenberName>
{
    [SerializeField] private GameObject tokinoSoraPrefab = null;
    [SerializeField] private GameObject robokoPrefab = null;
    [SerializeField] private GameObject AZKIPrefab = null;
    [SerializeField] private GameObject SakuraMikoPrefab = null;
    [SerializeField] private GameObject HoshimachiSuiseiPrefab = null;

    public override Puchi CreatePuchi(Enum.MenberName type)
    {
        Puchi puchi = null;

        switch (type)
        {
            case Enum.MenberName.TokinoSora:
                puchi = Instantiate(tokinoSoraPrefab).GetComponent<Puchi>();
                break;
            case Enum.MenberName.Roboco:
                puchi = Instantiate(robokoPrefab).GetComponent<Puchi>();
                break;
            case Enum.MenberName.AZKI:
                puchi = Instantiate(AZKIPrefab).GetComponent<Puchi>();
                break;
            case Enum.MenberName.SakuraMiko:
                puchi = Instantiate(SakuraMikoPrefab).GetComponent<Puchi>();
                break;
            case Enum.MenberName.HoshimachiSuisei:
                puchi = Instantiate(HoshimachiSuiseiPrefab).GetComponent<Puchi>();
                break;
            default:
                Debug.LogError("생성될 Puchi가 없습니다. MenberName또는 Prefab이 빠져있는지 확인하세요");
                break;
        }
        return puchi;
    }
}