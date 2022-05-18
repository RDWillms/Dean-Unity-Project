using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompoundCheck : MonoBehaviour
{
    public GameObject productSlot;
    public GameObject product;
    public Animator anim;

    public void Start()
    {
        product.SetActive(false);
    }
    public void Mixing()
    { //When all slots are filled and the compound button is pressed, the product image is activating and the com,pound anim plays//
        if (MixtureSlot.emptySlots == 0)
        {
            product.SetActive(true);
            anim.SetBool("Compounding?", true);
            Debug.Log("Ready to compound!");
        }
        else
        {
            Debug.Log("Not ready yet!");
        }
    }
}
