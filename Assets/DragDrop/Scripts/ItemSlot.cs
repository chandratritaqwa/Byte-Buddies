/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler {

    RectTransform itemHold;

    public void OnDrop(PointerEventData eventData) 
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) 
        {
            itemHold = eventData.pointerDrag.GetComponent<RectTransform>();
            itemHold.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
