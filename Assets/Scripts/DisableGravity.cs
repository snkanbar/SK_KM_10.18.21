using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class DisableGravity : MonoBehaviour

//public GameObject FallingObject;

//private NavMeshAgent Pasta;

{
    // In Unity's inspector window, populate with scene objects that you want to have gravity enabled on
    public Rigidbody[] objects;

    public Collider[] colliders;

    //public NavMeshSurface Agent;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log("Disable Gravity");
        if (Input.GetButtonDown("South"))

        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].useGravity = true;
            }

            for (int i = 0; i < colliders.Length; i++)
            {
                colliders[i].isTrigger = false;
            }

            //NavMesh.RemoveAllNavMeshData();

            //gameObject.active = false;
            //Debug.Break();
            //Pasta = GetComponent<NavMeshAgent>();
            //Pasta.SetDestination(Falldown.transform.position);

            //Destroy(gameObject);
            //renderer.enabled = false;
        }
    }
}