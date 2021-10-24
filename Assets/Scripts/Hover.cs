using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseOverExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private IEnumerator OnMouseOver()

    {
        {
            //If your mouse hovers over the GameObject with the script attached, output this message
            Debug.Log("Mouse is over GameObject.");
        }

        {
            for (float i = 0f; i <= 1f; i += 0.1f)
            {
                transform.localScale = new Vector3(
                (Mathf.Lerp(transform.localScale.x, transform.localScale.x + 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                (Mathf.Lerp(transform.localScale.y, transform.localScale.y + 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                (Mathf.Lerp(transform.localScale.z, transform.localScale.z + 0.025f, Mathf.SmoothStep(0f, 1f, i)))
                );
                yield return new WaitForSeconds(0.015f);
            }

            for (float i = 0f; i <= 1f; i += 0.1f)
            {
                transform.localScale = new Vector3(
                (Mathf.Lerp(transform.localScale.x, transform.localScale.x - 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                (Mathf.Lerp(transform.localScale.y, transform.localScale.y - 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                (Mathf.Lerp(transform.localScale.z, transform.localScale.z - 0.025f, Mathf.SmoothStep(0f, 1f, i)))
                );
                yield return new WaitForSeconds(0.015f);
            }
        }
    }
}

//public void OnMouseExit()
// {
//The mouse is no longer hovering over the GameObject so output this message each frame
//  Debug.Log("Mouse is no longer on GameObject.");

//}