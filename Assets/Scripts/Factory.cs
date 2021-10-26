using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Factory : MonoBehaviour
{
    //public GameObject Prefab;
    public GameObject[] Prefabs;

    public string TargetTag;
    public int MakeLimit = 55; //maximum agents before destruction
    private int _makeCount = 0; //each time we make an agent, add to count
    private GameObject Target;
    public GameObject StartButton;
    public GameObject DropButton;

    ///private Rigidbody rb;

    // In Unity's inspector window, populate with scene objects that you want to have gravity enabled on
    ///public Rigidbody[] objects;

    public float MakeRate = 2.0f;
    public Renderer rend;
    private float _lastMake = 0;
    //public bool convex;

    // Start is called before the first frame update
    private void Start()
    {
        StartButton.SetActive(true);
        DropButton.SetActive(false);

        /*GameObject[] targets = GameObject.FindGameObjectsWithTag(TargetTag);
        Target = targets[Random.Range(0, targets.Length)];
        rend = GetComponent<Renderer>();

        ///rb.useGravity = false;
        ///rb = GetComponent<Rigidbody>(); */
    }

    // Update is called once per frame
    private void Update()
    {
        //void Update()

        if (Input.GetButtonDown("North"))
        {
            StartButton.SetActive(false);
        }

        if (Input.GetButtonDown("North"))
        {
            GameObject[] targets = GameObject.FindGameObjectsWithTag(TargetTag);
            Target = targets[Random.Range(0, targets.Length)];
            rend = GetComponent<Renderer>();

            ///rb.useGravity = false;
            ///rb = GetComponent<Rigidbody>();
        }

        //guard statement
        if (Target == null) { return; }

        //destroy factory when limit reached
        if (_makeCount >= MakeLimit)
        {
            Debug.Log("Make Limit!");
            DropButton.SetActive(true); //Text

            if (Input.GetButtonDown("South"))
                DropButton.SetActive(false);
            Destroy(gameObject);

            //rb.useGravity = true;

            {
                ///for (int i = 0; i < objects.Length; i++)
               /// {
                 ///   objects[i].useGravity = true;
                ///}
            }
            // Destroy(gameObject);
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

        //Text textComponent = newobj.GetComponent<Text>(); //Not using for text
    }

    /* public void EnableGravity()
    {
        rb.useGravity = true;
    } */

    // Go through each rigidbody in the array and enable gravity
    //public void EnableGravity();

    /*public void changecolorred()
    {
        rend.material.SetColor("_Color", Color.red);
    }

    public void changecolorblue()
    {
        rend.material.SetColor("_Color", Color.blue);
    }

    public void changecoloryellow()
    {
        rend.material.color = Random.ColorHSV();*/
}