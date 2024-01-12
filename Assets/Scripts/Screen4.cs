using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Screen4 : MonoBehaviour
{
    [SerializeField] RectTransform slot1;
    [SerializeField] RectTransform slot2;
    [SerializeField] RectTransform itemPrint;
    [SerializeField] RectTransform itemOutput;
    [SerializeField] RectTransform itemHi;
    [SerializeField] Button checkAnswerButton;
    [SerializeField] TextMeshProUGUI validationText;
    Live liveScript;
    Score scoreScript;

    void Start()
    {
        liveScript = FindObjectOfType<Live>();
        scoreScript = FindObjectOfType<Score>();
    }

    public void CheckAnswer()
    {
        if(itemPrint.anchoredPosition == slot1.anchoredPosition && itemHi.anchoredPosition == slot2.anchoredPosition)
        {
            validationText.text = "YOU'RE CORRECT!";
            checkAnswerButton.interactable = false;
            scoreScript.IncreaseScore(100);
        }
        else
        {
            validationText.text = "YOU'RE WRONG!";
            liveScript.DecreaseLiveByOne();
        }
    }
}
