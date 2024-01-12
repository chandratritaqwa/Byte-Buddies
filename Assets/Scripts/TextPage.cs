using TMPro;
using UnityEngine;

public class TextPage : MonoBehaviour
{
    ScreenManager screenManager;
    [SerializeField] TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        screenManager = FindObjectOfType<ScreenManager>().GetComponent<ScreenManager>();

        ShowPage();
    }

    public void ShowPage()
    {
        textMeshPro.text = "PAGE " + (screenManager.currentPage + 1).ToString();
    }
}
