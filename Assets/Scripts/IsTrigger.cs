using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTrigger : MonoBehaviour
{
    private Collider m_ObjectCollider;

    private void Start()
    {
        //Fetch the GameObject's Collider (make sure they have a Collider component)
        m_ObjectCollider = GetComponent<Collider>();
        //Here the GameObject's Collider is not a trigger
        m_ObjectCollider.isTrigger = true;
        //Output whether the Collider is a trigger type Collider or not
        Debug.Log("Trigger On : " + m_ObjectCollider.isTrigger);
    }

    //    private void OnMouseDown()

    private void Update()

    {
        if (Input.GetButtonDown("West"))

        {
            //GameObject's Collider is now a trigger Collider when the GameObject is clicked. It now acts as a trigger
            m_ObjectCollider.isTrigger = false;
            //Output to console the GameObject’s trigger state
            Debug.Log("Trigger Off : " + m_ObjectCollider.isTrigger);
        }
    }
}