using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class Rotate : MonoBehaviour
{
    public GameObject Object;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("West"))

        {
            //transform.eulerAngles = new Vector3(0, -90, 0);
            Object.transform.Rotate(Vector3.up, 30.0f);
        }
              
    }

}