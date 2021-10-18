using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Click : MonoBehaviour
{
    public GameObject Target;

    public NavMeshAgent robo;

    // Start is called before the first frame update
    private void Start()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            robo.SetDestination(Target.transform.position);
            Debug.Log("Clicked on the Robot!");
        }
        else
        { return; }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}