using UnityEngine;
using UnityEngine.UI;

public class MainGameTimer : MonoBehaviour
{
    bool isUpdating;
    float gameOverTime;
    float currentTime;

    [SerializeField] private Image gaugeImage;

    private float targetFillAmount;
    private float currentFillAmount;

    private void Start()
    {
        isUpdating = true;
        gameOverTime = 60f;
        GameManager.GetInstance().ChangeState(Enum.GameState.Start);

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

    }
    void StopTimer(float duration)
    {

    }
    void ReStartTimer(float duration)
    {

    }
}
