using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeChildOf : MonoBehaviour
{
    //public GameObject OriginalParent1;    //Invoked when a button is pressed.
    //public GameObject OriginalParent2;
    //public GameObject OriginalParent3;
    public GameObject NewParent;

    public Collider Collider;
    private Rigidbody Rigidbody;
    //public Rigidbody Rigidbody;

    public void Start()
    {
        Collider = GetComponent<Collider>();
        Rigidbody = GetComponent<Rigidbody>();
    }

    //public void Update()

    // Disables gravity on all rigidbodies entering this collider.
    //void OnTriggerEnter(Collider other)

    //void OnTriggerEnter(Collider Collider)
    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent.transform.parent = NewParent.transform;

        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = false;


        //other.transform.parent.gameObject.GetComponent<Rigidbody>();
        //this.Rigidbody.useGravity = false;

        // OriginalParent1.transform.parent = NewParent.transform;
        // OriginalParent2.transform.parent = NewParent.transform;
        // OriginalParent3.transform.parent = NewParent.transform;

        //if (other.attachedRigidbody)
        //other.attachedRigidbody.useGravity = false;
    }
}