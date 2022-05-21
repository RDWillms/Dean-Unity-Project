using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public bool IsDragging;

    public Vector3 lastPos;

    private Collider2D _collider;

    private DragController _dragController;

    private float moveTime = 15f;

    private System.Nullable<Vector3> moveDestination;

    private void Start()
    {
        _collider = GetComponent<Collider2D>();
        _dragController = FindObjectOfType<DragController>();
    }

    void FixedUpdate()
    {
        if (moveDestination.HasValue)
        {
            if (IsDragging)
            {
                moveDestination = null;
                return;
            }

            if (transform.position == moveDestination)
            {
                gameObject.layer = DragLayer.Default;
                moveDestination = null;
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, moveDestination.Value, moveTime * Time.fixedDeltaTime);
            }
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Draggable collidedDraggable = other.GetComponent<Draggable>();

        /*if (collidedDraggable != null && _dragController.LastDragged.gameObject == gameObject)
        {
            ColliderDistance2D colliderDistance2D = other.Distance(_collider);
            Vector3 diff = new Vector3(colliderDistance2D.normal.x, colliderDistance2D.normal.y) * colliderDistance2D.distance;
            transform.position -= diff;
        }*/

        if (other.CompareTag("DropSlot"))
        {
            moveDestination = other.transform.position;
        }
        else if (other.CompareTag("Untagged"))
        {
            moveDestination = lastPos;
        }
    }
}
