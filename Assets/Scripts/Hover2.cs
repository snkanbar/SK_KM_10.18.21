using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover2 : MonoBehaviour

{
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnMouseOver()
    {
        text.SetActive(true);
        Debug.Log("Its Working!!!");
    }

    public void OnMouseExit()
    {
        // _callout.SetActive(false);
        Debug.Log("not hovering");
        text.SetActive(false);
    }
}