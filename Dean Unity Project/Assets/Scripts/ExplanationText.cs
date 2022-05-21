using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplanationText : MonoBehaviour
{ //Creates an array of text boxes to display sets of explanation text
    [TextArea(3, 5)] //Min of 3 text instances and a Max of 5
    public string[] explanations;
}
