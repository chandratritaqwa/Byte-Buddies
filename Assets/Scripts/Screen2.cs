using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Screen2 : MonoBehaviour
{
    Button[] choiceButtons;
    Button selectedButton;
    Live liveScript;
    Score scoreScript;
    [SerializeField] Button checkAnswerButton;
    [SerializeField] TextMeshProUGUI validationText;
    [SerializeField] Button correctAnswerButton;

    void Start()
    {
        choiceButtons = GetComponentsInChildren<Button>();
        checkAnswerButton.interactable = false;
        liveScript = FindObjectOfType<Live>();
        scoreScript = FindObjectOfType<Score>();
    }

    /*
    void OnEnable() 
    {
        ResetScreen();
    }
    */

    // Button click, make it disable. Other enable
    public void OnChoicesClick(Button clickedButton)
    {
        checkAnswerButton.interactable = true;
        foreach(Button button in choiceButtons)
        {
            if(button.gameObject.name == clickedButton.gameObject.name)
            {
                clickedButton.interactable = false;
                selectedButton = clickedButton;
            }
            else
            {
                button.interactable = true;
            }
        }
    }

    public void OnCheckAnswerClick()
    {
        if(selectedButton == correctAnswerButton)
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
    
    void ResetScreen()
    {
        // check answer - false
        // all choices - true
        // Validation text - Null
        foreach(Button button in choiceButtons)
        {
            button.interactable = true;
        }
        validationText.text = "";
        checkAnswerButton.interactable = true;
    }
}
