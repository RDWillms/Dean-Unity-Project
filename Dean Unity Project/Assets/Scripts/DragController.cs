using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragController : MonoBehaviour
{
    public Draggable LastDragged => lastDragged;
    private bool dragging = false;
    private Vector2 screenPos;
    private Vector2 worldPos;
    private Draggable lastDragged;

    private void Awake()
    {
        DragController[] controller = FindObjectsOfType<DragController>();
        if (controller.Length > 1)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (dragging)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Drop();
                return;
            }
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            screenPos = new Vector2(mousePos.x, mousePos.y);
        }
        else
        {
            return;
        }

        worldPos = Camera.main.ScreenToWorldPoint(screenPos);

        if (dragging)
        {
            Drag();
        }
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero);
            if (hit.collider !=null)
            {
                Draggable draggable = hit.transform.gameObject.GetComponent<Draggable>();
                if (draggable != null)
                {
                    lastDragged = draggable;
                    startDrag();
                }
            }
        }
    }

    void startDrag()
    {
        lastDragged.lastPos = lastDragged.transform.position;
        dragStatus(true);
    }

    void Drag()
    {
        lastDragged.transform.position = new Vector2(worldPos.x, worldPos.y);
    }

    void Drop()
    {
        dragStatus(false);
    }

    void dragStatus(bool isDragging)
    {
        dragging = lastDragged.IsDragging = isDragging;
        lastDragged.gameObject.layer = isDragging ? DragLayer.Dragging : DragLayer.Default;
    }
}
