using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cursor : MonoBehaviour
{
    //global variables
    public float Speed = 10.0f;

    public LayerMask SelectMask;
    public LayerMask PlaceMask;
    private RectTransform rect;

    // Start is called before the first frame update
    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    private bool _isRelocating = false;
    private GameObject _selectedFactory;

    // Update is called once per frame
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(rect.position);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.black);

        RaycastHit hit;
        if (_isRelocating)
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity, PlaceMask))
            {
                float yy = _selectedFactory.transform.localScale.y / 2.0f;
                _selectedFactory.transform.position = hit.point + new Vector3(0, yy, 0);
                if (Input.GetButtonDown("East"))
                {
                    Factory factory = _selectedFactory.GetComponent<Factory>();
                    factory.enabled = true;
                    _isRelocating = false;
                }
            }
        }
        else
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity, SelectMask))
            {
                /// Debug.Log("Factory");
                ///GameObject.Find("Bowl").SendMessage("changecoloryellow");

                //Factory color = _selectedFactory.GetComponent<Renderer>().material.SetColor("_Color",cursorOver)
                //var factoryrenderer = colorchangefactory.GetComponent<Renderer>();
                //factoryrenderer.material.SetColor("",Color.red);

                if (Input.GetButtonDown("East"))
                {
                    _selectedFactory = hit.transform.gameObject;
                    Factory factory = _selectedFactory.GetComponent<Factory>();
                    factory.enabled = false;
                    _isRelocating = true;
                }
            }
            else
            {
                Debug.Log("FactoryOUT");
                GameObject go = GameObject.Find("Factory");
                //if (go != null) { go.SendMessage("changecolorblue"); }
            }

            //get input
            Vector2 joy = new Vector2(Input.GetAxis("RightJoyX"), -Input.GetAxis("RightJoyY"));
            if (joy.magnitude < 0.3f) { return; }
            joy.Normalize();

            //local variables
            float width = Screen.width;
            float height = Screen.height;
            float multiplier = Speed * Time.deltaTime;
            Vector2 anchor = rect.anchoredPosition;

            //update values
            float x = anchor.x + joy.x * multiplier;
            x = Mathf.Clamp(x, -width / 2, width / 2);
            float y = anchor.y + joy.y * multiplier;
            y = Mathf.Clamp(y, -height / 2, height / 2);

            //set anchor
            anchor = new Vector2(x, y);
            rect.anchoredPosition = anchor;
        }
    }
}