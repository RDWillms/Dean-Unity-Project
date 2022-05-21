using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class OnHover : MonoBehaviour

{
    public CompoundCheck compoundCheck;

    public GameObject text;
    public TextMeshProUGUI explanationText;
    public ExplanationText myText;

    bool Stop;

    public int index;

    public void Update()
    {
        StopText();
    }

    void OnMouseOver()
    { if (Stop == false)
        {
            //Sets to where it will activate text when hovering over item//
            //text.SetActive(true);
            explanationText.text = myText.explanations[index]; //Sets explanation text to the explanations array. The int variable determines what element in the array is displayed in the text.
        }
    }

    private void OnMouseExit()
    {
        if (Stop == false)
        {
            explanationText.text = null;
        }
    }
    void StopText()
    {
        if (compoundCheck.Compounded == true)
        { //When all empty slots are filled, deactivate explanationText//
            //text.SetActive(false);
            Stop = true;
            explanationText.text = myText.explanations[4];
            Debug.Log("Stop is true");
        }
    }
}
    
