using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    [HideInInspector] public int currentPage;
    public GameObject[] pages;

    void Start() 
    {
        currentPage = 0;
        SetPage(0);
    }

    void SetPage(int page)
    {
        for(int i = 0; i < pages.Length; i++)
        {
            if(i == page)
            {
                pages[i].SetActive(true);
                continue;
            }
            
            pages[i].SetActive(false);
        }
    }

    public void NextPage()
    {
        currentPage++;

        if(currentPage >= pages.Length)
        {
            currentPage--;
        }

        SetPage(currentPage);
    }

    public void PreviousPage()
    {
        currentPage--;

        if(currentPage < 0)
        {
            currentPage++;
        }

        SetPage(currentPage);
    }
}
