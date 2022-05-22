using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public GameObject startButton;

    private Queue<string> sentences;

    void Start()
    { //Sets start button to false at beginning of scene and begins to Queue up text from sentences array.
        startButton.SetActive(false);
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        sentences.Clear(); //Before Dialgoue seqeunce beings, empties out the array.
        Debug.Log("Beginning conversation");

        foreach (string sentence in dialogue.sentences) //This constantly checks if there is an available element in the array and then begins queueing up more sentences.
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    { //This function checks to see if the Queue has anymore sentences left. If not, runs EndDialgoue function.
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    { //Once it detects that there is no more dialgue to go through, activates the start button so the player can start the game.
        startButton.SetActive(true);
        Debug.Log("End of conversation. Ready to play!");
    }
}
