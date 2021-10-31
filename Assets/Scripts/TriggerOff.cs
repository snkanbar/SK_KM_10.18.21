using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOff : MonoBehaviour

{
    //public Collider Collider;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("South"))
            //GetComponent<Collider>().enabled = false;
            GetComponent<IsTrigger>().enabled = true;
    }
}