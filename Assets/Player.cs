using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public string restartScene;

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;

        transform.position = pos;


        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(restartScene);
        }
    }
}
