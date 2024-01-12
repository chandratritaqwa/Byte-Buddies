using TMPro;
using UnityEngine;


public class Live : MonoBehaviour
{
    TextMeshProUGUI txtLives;
    int liveNum;

    void Start()
    {
        // Show Lives: 3
        txtLives = GetComponent<TextMeshProUGUI>();
        liveNum = 3;
    }

    void ShowLives()
    {
        txtLives.text = "LIVES: " + liveNum.ToString();
    }

    public void DecreaseLiveByOne()
    {
        if(liveNum > 0)
        {
            liveNum--;        
        }
        ShowLives();
    }
}

