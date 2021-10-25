using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Fall : MonoBehaviour
{
    // In Unity's inspector window, populate with scene objects that you want to have gravity enabled on
    public Rigidbody[] objects;

    public GameObject Falldown;

    private NavMeshAgent Pasta;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("North")) ;
        Pasta = GetComponent<NavMeshAgent>();
        Pasta.SetDestination(Falldown.transform.position);
    }

    // Go through each rigidbody in the array and enable gravity
    //public void EnableGravity()
}