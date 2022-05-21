using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    public GameObject mixture;
    private bool dragging;
    private bool isPlaced;

    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;

    // Start is called before the first frame update
    void Start()
    {
        resetPosition = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
        }
    }

    private void OnMouseDown()
    {
        if (isPlaced == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                startPosX = mousePos.x - this.transform.localPosition.x;
                startPosY = mousePos.y - this.transform.localPosition.y;

                dragging = true;
            }
        }
        
    }
    private void OnMouseUp()
    {
        dragging = false;

        if (Mathf.Abs(this.transform.localPosition.x - mixture.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.y - mixture.transform.localPosition.y) <= 0.5f)
        {
            this.transform.localPosition = new Vector3(mixture.transform.position.x, mixture.transform.position.y, mixture.transform.position.z);
            isPlaced = true;
        } 
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
