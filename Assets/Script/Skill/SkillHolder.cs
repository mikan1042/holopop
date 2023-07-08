using System;
using UnityEngine;
using UnityEngine.UI;

public class SkillHolder : MonoBehaviour
{
    [SerializeField] private bool isSkillAvailable;
    [SerializeField] private float gauge;
    [SerializeField] private float maxGauge;
    [SerializeField] private Image gaugeImage;
    [SerializeField] private BaseSkill skill;

    private void Start()
    {
        gauge = 0f;
        gaugeImage.fillAmount = gauge;

        CreateSkill();
    }

    private void CreateSkill()
    {
        var skillName = GameSetting.GetInstance().GetSkillName();
        Type skillType = Type.GetType(skillName);

        if (skillType != null)
            skill = (BaseSkill)gameObject.AddComponent(skillType);
    }
    public void Execute()
    {
        if (isSkillAvailable)
        {
            skill.Execute();
            ResetSkillInfo();
            // PuchiBox.GetInstance().Reco
        }
    }
    private void ResetSkillInfo()
    {
        isSkillAvailable = false;
        gauge = 0;
        gaugeImage.fillAmount = gauge;
    }
    public void FillGauge(Chain chain)
    {
        if (isSkillAvailable) return;

        gauge += chain.puchis.Count / 100f;

        Debug.Log(chain.puchis.Count);

        if (gauge > 1)
        {
            isSkillAvailable = true;
            gauge = 1;
        }
        gaugeImage.fillAmount = gauge;
    }
}
