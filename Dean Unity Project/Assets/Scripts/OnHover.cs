using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnHover : MonoBehaviour

{
    public GameObject text;
    bool Stop;
    //public Text UIText;
    public void Start()
    {
        text.SetActive(false);
        //UIText = text.GetComponent<Text>();
    }

    public void Update()
    {
        StopText();
    }

    void OnMouseOver()
    { if (Stop == false)
        {
            //Sets to where it will activate text when hovering over item//
            text.SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        if (Stop == false)
        {
            text.SetActive(false);
        }
    }
    void StopText()
    {
        if (MixtureSlot.emptySlots == 0)
        { //When all empty slots are filled, deactivate mixtureText//
            text.SetActive(false);
            Stop = true;
            Debug.Log("Stop is true");
        }
    }
}
    
