using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class EnableGravity : MonoBehaviour

{
    // In Unity's inspector window, populate with scene objects that you want to have gravity enabled on
    public Rigidbody[] objects;

    public Collider[] colliders;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log("Enable Gravity");
        void OnTriggerEnter(Collider other)

        //if (Input.GetButtonDown("South"))

        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].useGravity = true;
            }

            for (int i = 0; i < colliders.Length; i++)
            {
                colliders[i].isTrigger = false;
            }
        }
    }
}