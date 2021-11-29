using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour

{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Rigidbody rBody = GetComponent<Rigidbody>();
        void EnableRagdoll()
        {
            rBody.isKinematic = false;
            rBody.detectCollisions = true;
        }
        void DisableRagdoll()
        {
            rBody.isKinematic = true;
            rBody.detectCollisions = false;
        }
    }
}