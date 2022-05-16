using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnHover : MonoBehaviour

{
    public GameObject text;
    public void Start()
    {
        text.SetActive(false);
    }
    // Update is called once per frame
    void OnMouseOver()
    {
        text.SetActive(true);
    }

    private void OnMouseExit()
    {
        text.SetActive(false);
    }
}
