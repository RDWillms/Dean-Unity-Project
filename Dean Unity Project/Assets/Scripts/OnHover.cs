using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class OnHover : MonoBehaviour

{
    public CompoundCheck compoundCheck; //Referencing CompoundCheck script to see when all the mixtures are combined.

    public TextMeshProUGUI explanationText; //TMPro text box
    public ExplanationText myText; //Array of explanation text

    bool Stop;

    public int index; //Public variable that let's me determine which elelment in the text array each object should display on hover.

    public void Update()
    {
        StopText();
    }

    void OnMouseOver() //Shows text when mouse hovers over collider on mixture game object
    { if (Stop == false) //Checks to see if it shoudl stop showing the text. If not, displays text in array
        {
            explanationText.text = myText.explanations[index]; //Sets explanation text to the explanations array. The int variable determines what element in the array is displayed in the text.
        }
    }

    private void OnMouseExit() //Stops showing text when mouse leaves collider in game object
    {
        if (Stop == false)
        {
            explanationText.text = null; //Checks to see if the text should stop dispalying on hover and sets the text to null;
        }
    }
    void StopText()
    {
        if (compoundCheck.Compounded == true)
        { //When all empty slots are filled, deactivate explanationText//
            Stop = true;
            explanationText.text = myText.explanations[4]; //Sets to product description since that description is always going to be the 5th element in the text array
            Debug.Log("No mixtures left to Drag");
        }
    }
}
    
