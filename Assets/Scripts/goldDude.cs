using UnityEngine;
using UnityEngine.SceneManagement;

public class goldDude : MonoBehaviour
{
    private Scene scene;
    private int nextLevel;

    void Start()
    {
        nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
