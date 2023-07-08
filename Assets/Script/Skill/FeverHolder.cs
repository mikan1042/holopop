using UnityEngine;
using UnityEngine.UI;

public class FeverHolder : MonoBehaviour
{
    public bool isFever { get; private set; }
    [SerializeField] private float gauge;
    [SerializeField] private float maxGauge;
    [SerializeField] private float duration;    // feverTime
    [SerializeField] private float dt;

    [SerializeField] private Image gaugeImage;

    private float fillSpeed;

    private float targetFillAmount;
    private float currentFillAmount;



    private void Start()
    {
        isFever = false;
        gauge = 0f;
        maxGauge = 100f;
        duration = 5f; 
        dt = 0f;
        gaugeImage.fillAmount = 0f;


        targetFillAmount = 0f;
        currentFillAmount = 1f;
        fillSpeed = 5f;
    }
    private void Update()
    {
        // 나중에 코루틴으로 변경해도 괜찮을 것 같음
        if (!isFever) return;

        dt += Time.deltaTime;

        if (currentFillAmount > targetFillAmount)
        {
            float decreaseAmount = (1 / fillSpeed) * Time.deltaTime;
            currentFillAmount = Mathf.Max(currentFillAmount - decreaseAmount, targetFillAmount);
            gaugeImage.fillAmount = currentFillAmount;
        }


        if (dt > duration) OnFeverTimeEnd();
    }

    private void OnFever()
    {

    }
    private void OnFeverTimeEnd()
    {
        currentFillAmount = 1f;
        isFever = false;
        dt = 0f;
        gauge = 0f;
    }



    public void FillGauge(Chain chain)
    {
        if (isFever) return;

        gauge += chain.puchis.Count / 100f;

        Debug.Log(chain.puchis.Count);

        if (gauge > 1)
        {
            isFever = true;
            gauge = 1;
        }
        gaugeImage.fillAmount = gauge;
    }
}
