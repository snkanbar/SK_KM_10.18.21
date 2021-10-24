using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject Prefab;

    //public GameObject Prefab2;
    public string TargetTag;

    public int MakeLimit = 6; //Maximum Agents Before Destruction
    private int _makecount = 0; //Each Time We Make An Agent, Add To Count
    private GameObject Target;

    public float MakeRate = 2.0f;
    public Renderer rend;
    private float _lastMake = 0;

    // Start is called before the first frame update
    private void Start()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag(TargetTag);
        Target = targets[Random.Range(0, targets.Length)];
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Guard Statement
        if (Target == null) { return; }

        //Destroy Factory When Limit Reached
        if (_makecount >= MakeLimit)
        {
            CancelInvoke();
            //Destroy(gameObject);
        }

        _lastMake += Time.deltaTime; //_lastMake = _lastMake + Time.deltaTime;
        if (_lastMake > MakeRate)
        {
            //Debug.Log("Make");
            _lastMake = 0; //reset time counter
            _makecount++; //Increase Agent Make Count By One
            GameObject go = Instantiate(Prefab, this.transform.position, Quaternion.identity);
            MobileUnit mu = go.GetComponent<MobileUnit>();
            mu.Target = Target;
        }
    }

    public void changecolorred()
    {
        rend.material.SetColor("_Color", Color.red);
    }

    public void changecolorblue()
    {
        rend.material.SetColor("_Color", Color.blue);
    }

    public void changecoloryellow()
    {
        rend.material.color = Random.ColorHSV();
    }
}