using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    int scoreNum;
    [SerializeField] TextMeshProUGUI scoreText;

    void Start()
    {
        scoreNum = 0;
        //ShowScore();
    }

    public void IncreaseScore(int num)
    {
        scoreNum += num;
        ShowScore();
    }


    public void ShowScore()
    {
        scoreText.text = "SCORE : " + scoreNum.ToString();
    }
}
