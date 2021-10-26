using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTrigger : MonoBehaviour
{
    private Collider ObjectCollider;

    private void Start()
    {
        //Fetch the GameObject's Collider (make sure they have a Collider component)
        ObjectCollider = GetComponent<Collider>();
        //Here the GameObject's Collider is not a trigger
        ObjectCollider.isTrigger = true;
        //Output whether the Collider is a trigger type Collider or not
        Debug.Log("Trigger On : " + ObjectCollider.isTrigger);
    }

    //    private void OnMouseDown()

    private void Update()

    {
        if (Input.GetButtonDown("South"))

        {
            //GameObject's Collider is now a trigger Collider when the GameObject is clicked. It now acts as a trigger
            ObjectCollider.isTrigger = false;
            //Output to console the GameObject’s trigger state
            Debug.Log("Trigger Off : " + ObjectCollider.isTrigger);
        }
    }
}