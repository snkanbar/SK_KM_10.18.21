using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using System.Linq;

public class Factory : MonoBehaviour
{
    //public GameObject Prefab;
    public GameObject[] Prefabs;

    public string TargetTag;
    public int MakeLimit = 55; //maximum agents before destruction
    private int _makeCount = 0; //each time we make an agent, add to count
    public NavMeshSurface Agent;
    private GameObject Target;
    public GameObject StartButton;
    public GameObject DropButton;

    public float MakeRate = 2.0f;
    public Renderer rend;
    private float _lastMake = 0;

    //pass through plane
    public GameObject Plane;

    //scripts
    public NavMeshAgent FusiNavMeshAgent;

    public MobileUnit FusiMobileUnit;
    public CollisionDetection FusiCollisionDetection;

    public NavMeshAgent MacNavMeshAgent;
    public MobileUnit MacMobileUnit;
    public CollisionDetection MacCollisionDetection;

    public NavMeshAgent BowtieNavMeshAgent;
    public MobileUnit BowtieMobileUnit;
    public CollisionDetection BowtieCollisionDetection;

    //ADDED FROM DISABLE GRAVITY SCRIPT
    //public Rigidbody[] objects;
    //public Collider[] colliders;

    // Start is called before the first frame update
    private void Start()
    {
        StartButton.SetActive(true);
        DropButton.SetActive(false);

        Debug.Log("Set Target Active!");
        Target.SetActive(true);

        Plane = GameObject.Find("Plane");
        //Plane.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("North"))
        {
            StartButton.SetActive(false);
        }

        if (Input.GetButtonDown("North"))
        {
            GameObject[] targets = GameObject.FindGameObjectsWithTag(TargetTag);
            Target = targets[Random.Range(0, targets.Length)];
            rend = GetComponent<Renderer>();
        }

        //guard statement
        if (Target == null) { return; }

        //remove navmesh data
        if (Input.GetButtonDown("South"))
        {
            Destroy(Target);
            NavMesh.RemoveAllNavMeshData();

            //Plane = GameObject.Find("Plane");
            Plane.SetActive(true);

            //FusiNavMeshAgent.enabled = true;
            //FusiCollisionDetection.enabled = true;
            //FusiMobileUnit.enabled = true;

            //MacNavMeshAgent.enabled = true;
            //MacCollisionDetection.enabled = true;
            //MacMobileUnit.enabled = true;

            //BowtieNavMeshAgent.enabled = true;
            //BowtieCollisionDetection.enabled = true;
            //BowtieMobileUnit.enabled = true;

            //for (int i = 0; i < objects.Length; i++)
            //{
            //    objects[i].useGravity = true;
            //}

            //for (int i = 0; i < colliders.Length; i++)
            //{
            //    colliders[i].isTrigger = false;
            //}

            //DropButton.SetActive(false);
            //Destroy(Target);
        }

        //ADDED FROM DISABLE GRAVITY SCRIPT
        //Debug.Log("Disable Gravity");
        //if (Input.GetButtonDown("South"))

        {
            //for (int i = 0; i < objects.Length; i++)
            {
                //    objects[i].useGravity = true;
            }

            // for (int i = 0; i < colliders.Length; i++)
            {
                //   colliders[i].isTrigger = false;
            }
        }

        //destroy factory when limit reached
        if (_makeCount >= MakeLimit)
        {
            Debug.Log("Make Limit!");
            DropButton.SetActive(true); //Text
        }

        _lastMake += Time.deltaTime; //_lastMake = _lastMake + Time.deltaTime;
        if (_lastMake > MakeRate)
        {
            //Debug.Log("Make");
            _lastMake = 0; //reset time counter
            _makeCount++; //increase agent make count by one
            GameObject prefab = Prefabs[Random.Range(0, Prefabs.Length)];
            GameObject go = Instantiate(prefab, this.transform.position, Quaternion.identity);
            MobileUnit mu = go.GetComponent<MobileUnit>();
            mu.Target = Target;
        }

        {
            //if (Input.GetButtonDown("South"))
            //////////////  NavMesh.RemoveAllNavMeshData();

            //NavMeshSurface.Stop();
            //NavMeshSurface.ResetPath();

            //Agent.ResetPath();
            //Target = null;
        }
    }
}