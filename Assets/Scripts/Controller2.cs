using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("North")) { Debug.Log("North"); }
        if (Input.GetButtonDown("South")) { Debug.Log("South"); }

        // Vector3 right = new Vector3(Input.GetAxis("RightJoyX"), 0, 0);

        var x = Input.GetAxis("RightJoyX");

        transform.Rotate(x, 0, 0);
    }
}