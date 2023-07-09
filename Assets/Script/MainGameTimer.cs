using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MainGameTimer : MonoBehaviour
{
    public bool isUpdating;
    float gameOverTime;
    float currentTime;

    [SerializeField] private Image gaugeImage;

    private float targetFillAmount;
    private float currentFillAmount;

    private void Start()
    {
        isUpdating = false;
        gameOverTime = 60f;

        targetFillAmount = 0f;
        currentFillAmount = 1f;
    }
    private void Update()
    {
        if (isUpdating)
        {
            currentTime += Time.deltaTime;

            if (currentFillAmount > targetFillAmount)
            {
                float decreaseAmount = (1 / gameOverTime) * Time.deltaTime;
                currentFillAmount = Mathf.Max(currentFillAmount - decreaseAmount, targetFillAmount);
                gaugeImage.fillAmount = currentFillAmount;
            }

            if (currentTime >= gameOverTime)
            {
                isUpdating = false;
                GameManager.GetInstance().ChangeState(Enum.GameState.BonusBoom);
            }
        }

    }
    void AddTimerToTime(float time)
    {
        currentTime += time;
    }
    void StopTimer(float duration)
    {
        isUpdating = false;
    }
    void ReStartTimer(float duration)
    {
        isUpdating = true;
    }
}
