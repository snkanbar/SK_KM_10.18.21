using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour
{
    public float firingForce = 500;
    public GameObject object2Throw;
    public GameObject barrels;
    public GameObject Ramps;
    public Camera RMCamera;

    public GameObject objectCannon;

    public Transform mousePOS;
    public Transform target;

    private Plane plane;

    private void Start()
    {
        plane = new Plane(Vector3.forward, Vector3.zero);
    }

    private void Update()
    {
        if (Input.GetButtonDown("South"))
        {
            Debug.Log("Firing");
            var mousePos = Input.mousePosition;
            mousePos.z = 10.0f;       // we want 2m away from the camera position
            var objectPos = RMCamera.ScreenToWorldPoint(mousePos);
            if (object2Throw != Ramps)
            {
                GameObject tossedObj = (GameObject)Instantiate(object2Throw, objectPos, objectCannon.transform.rotation);
                tossedObj.GetComponent<Rigidbody>().AddForce(objectCannon.transform.forward * firingForce);
            }
            else
            {
                Instantiate(object2Throw, objectPos, Quaternion.Euler(270, 90, 0));
            }
        }

        //target.position = RMCamera.ScreenToWorldPoint(Input.mousePosition);
        //objectCannon.transform.LookAt(target);
        RaycastHit hit;
        Ray ray = RMCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 hitPosition = hit.point;
            objectCannon.transform.LookAt(hitPosition);
            // Do something with the object that was hit by the raycast.
        }
    }

    public void makeBarrels()
    {
        object2Throw = barrels;
    }

    public void makeRamps()
    {
        object2Throw = Ramps;
    }
}