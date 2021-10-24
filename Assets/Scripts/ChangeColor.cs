using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//using UnityEngine.InputSystem;

public class ChangeColor : MonoBehaviour
{
    public Color startColor;
    public Color mouseOverColor;
    public bool mouseOver = false;

    public void OnMouseEnter()
    {
        mouseOver = true;
        GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);
    }

    public void OnMouseExit()
    {
        mouseOver = false;
        GetComponent<Renderer>().material.SetColor("_Color", startColor);
    }
}