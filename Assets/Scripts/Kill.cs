using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel(scene.name);
        }
    }


}
