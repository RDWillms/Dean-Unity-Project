using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void Start ()
    { //Finds object 'Dialogue Manager' and tells it to beging the StartDialogue function from referenced Dialogue script.
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
