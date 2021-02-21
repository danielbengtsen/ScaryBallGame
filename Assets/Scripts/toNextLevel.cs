using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toNextLevel : MonoBehaviour
{
    private int nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        nextLevel = SceneManager.GetActiveScene().buildIndex +1;
    }

    void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene(nextLevel);
    }
}
