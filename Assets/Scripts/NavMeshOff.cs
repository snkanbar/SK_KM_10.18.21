using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using System.Linq;

public class NavMeshOff : MonoBehaviour
{
    public NavMeshSurface Agent;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("South"))
            NavMesh.RemoveAllNavMeshData();
    }
}