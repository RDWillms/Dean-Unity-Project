using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompoundCheck : MonoBehaviour
{
    public GameObject product;

    public void Start()
    {
        product.SetActive(false);
    }
    public void Mixing()
    {
        if (MixtureSlot.emptySlots == 0) {
            product.SetActive(true);
            Debug.Log("Ready to compound!");
        } 
        else {
            Debug.Log("Not ready yet!");
        }
    }

  
}
