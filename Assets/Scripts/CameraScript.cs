using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    public GameObject the_ball;

    private Vector3 offset;


    void Start()
    {
        offset = transform.position - the_ball.transform.position;
    }

    void LateUpdate()
    {
        transform.position = the_ball.transform.position + offset;
        

    }
    void Update()
    {

        // transform.LookAt(the_ball.transform.position);
        // transform.Translate(Vector3.right * Time.deltaTime);
        // Spin the object around the target at 20 degrees/second.
        //transform.RotateAround(the_ball.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}