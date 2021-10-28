using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTrigger : MonoBehaviour
{
    public Collider ParentObjectCollider;
    public Collider ChildObjectCollider;

    private void Start()
    {
        //Fetch the GameObject's Collider (make sure they have a Collider component)
        ParentObjectCollider = GetComponentInParent<Collider>();
        ChildObjectCollider = GetComponentInChildren<Collider>();
        //Here the GameObject's Collider is not a trigger
        ParentObjectCollider.isTrigger = false;
        ChildObjectCollider.isTrigger = false;
        //Output whether the Collider is a trigger type Collider or not
        Debug.Log("Trigger On : " + ParentObjectCollider.isTrigger);
        Debug.Log("Trigger On : " + ChildObjectCollider.isTrigger);
    }

    //    private void OnMouseDown()

    private void Update()

    {
        if (Input.GetButtonDown("West"))

        {
            //GameObject's Collider is now a trigger Collider when the GameObject is clicked. It now acts as a trigger
            ParentObjectCollider.isTrigger = true;
            ChildObjectCollider.isTrigger = true;
            //Output to console the GameObject’s trigger state
            Debug.Log("Trigger Off : " + ParentObjectCollider.isTrigger);
            Debug.Log("Trigger Off : " + ChildObjectCollider.isTrigger);
        }
    }
}