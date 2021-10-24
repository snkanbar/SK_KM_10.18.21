using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorRandomly : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("South"))
        {
            this.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }
}