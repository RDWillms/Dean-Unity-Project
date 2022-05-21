using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_N_Drop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler {
    
    [SerializeField] private Canvas canvas;
    
    private RectTransform rectTransform;
    public Transform startPosition = null;
    private CanvasGroup canvasGroup;
    private MixtureSlot Placed;

    private void Awake()
    {
        {
            rectTransform = GetComponent<RectTransform>();
            canvasGroup = GetComponent<CanvasGroup>();
            //Placed.isPlaced = false;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    { //Once dragging, lowers the alpha of the canvas group of the object by 50%//
            //eventData.pointerDrag = null;
            Debug.Log("BeginDrag");
            canvasGroup.alpha = .5f;
            canvasGroup.blocksRaycasts = false;


    }
    public void OnDrag(PointerEventData eventData)
    { //Sets anchor position of the RectTransform fo the UI element to the position fo the cursor.//
        Debug.Log("Dragging");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

    }

    public void OnEndDrag(PointerEventData eventData)
    {  //When dragging has ended returns canvasGroup alpha back to 100%//
        Debug.Log("EndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        
        //if (Placed.isPlaced == true)
        //{

        /* }
         else
         {
             return;
         }*/
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
}