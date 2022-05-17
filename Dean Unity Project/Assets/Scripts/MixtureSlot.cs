using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MixtureSlot : MonoBehaviour, IDropHandler  
{
    public static int emptySlots = 0;
    

    public void Awake()
    {
        emptySlots++;
    }
    public void OnDrop(PointerEventData eventData)

    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            emptySlots--;
            Debug.Log("This box is filled");
            Debug.Log(emptySlots);
        } else if(eventData.pointerDrag = null)
        {
            emptySlots++;
            Debug.Log("This box is no longer filled. Empty slots: ");
        }
    }
}
