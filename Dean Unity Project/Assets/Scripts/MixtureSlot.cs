using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MixtureSlot : MonoBehaviour, IDropHandler
{
    public static int emptySlots = 0;
    public bool isPlaced;
    

    public void Awake()
    { //When game is first run, adds how many productSlots are present in the scene and adds that number to the emptySlots variable//
        emptySlots++;
    }

    public void OnDrop(PointerEventData eventData)

    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        { //When mixture is dropped on top of productSlot UI element it snaps the mixture to the anchor position of the Slot//
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            emptySlots--; //Decreases the amount of empty slots in the scne by one
            isPlaced = true;
            eventData.pointerDrag = null; //Disables dragging capability on mixture
            Debug.Log("Placed mixture in slot");
            Debug.Log("Empty slots: " + emptySlots); //Prints out how many empty slots are lef tin the scene
        } 
    }

    

}
