using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Screen6 : MonoBehaviour
{
    // Swapping places drag and drop something here
    [SerializeField] RectTransform[] slots;
    [SerializeField] RectTransform[] prints;

    [SerializeField] TextMeshProUGUI validationText;
    [SerializeField] Button checkAnswerButton;

    Live liveScript;
    Score scoreScript;

    void Start()
    {
        liveScript = FindObjectOfType<Live>();
        scoreScript = FindObjectOfType<Score>();
    }

    public void CheckAnswer()
    {
        bool isAnswerCorrect = true;
        for(int i = 0; i < prints.Length; i++)
        {
            if(prints[i].anchoredPosition != slots[i].anchoredPosition)
            {
                validationText.text = "YOU'RE WRONG!";
                liveScript.DecreaseLiveByOne();
                isAnswerCorrect = false;
                break;
            }
        }

        if(isAnswerCorrect)
        {
            validationText.text = "YOU'RE CORRECT!";
            checkAnswerButton.interactable = false;
            scoreScript.IncreaseScore(100);
        }
    }

}
