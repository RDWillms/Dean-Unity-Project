using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompoundCheck : MonoBehaviour
{
    public GameObject productSlot;
    public GameObject product;
    public GameObject continueButton;

    public Animator anim;
    
    public bool Compounded;

    public void Start()
    { //At beginning of scene, hides the final product and continue button from the scene.
        product.SetActive(false);
        continueButton.SetActive(false);
}
    public void Mixing()
    { //When all slots are filled and the compound button is pressed, the product image is activating and the compound anim plays//
        if (MixtureSlot.emptySlots == 0)
        {
            product.SetActive(true);
            anim.SetBool("Compounding?", true); //Activates animation when Compounding is set to true
            Compounded = true;
            continueButton.SetActive(true);
            Debug.Log("Compounding mixtures!");
        }
        else
        {
            Debug.Log("Not ready yet!");
        }
    }
}
