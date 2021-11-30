using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeChildOf : MonoBehaviour
{
    public GameObject OriginalParent1;    //Invoked when a button is pressed.
    public GameObject OriginalParent2;
    public GameObject OriginalParent3;
    public GameObject NewParent;
    public Collider Collider;
    
    public void Start()
    {
        Collider = GetComponent<Collider>();
    }

    //public void Update()



    // Disables gravity on all rigidbodies entering this collider.
    //void OnTriggerEnter(Collider other)

    //void OnTriggerEnter(Collider Collider)
    void OnTriggerEnter(Collider other)     
    {
        OriginalParent1.transform.parent = NewParent.transform;
        OriginalParent2.transform.parent = NewParent.transform;
        OriginalParent3.transform.parent = NewParent.transform;

        //if (other.attachedRigidbody)
        //other.attachedRigidbody.useGravity = false;
    }
}
    

