using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R))
        if (Input.GetButtonDown("East"))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name, LoadSceneMode.Single);
            Debug.Log("reset");
        }
    }
}