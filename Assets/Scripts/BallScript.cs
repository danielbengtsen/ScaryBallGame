using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public Transform camPivot;
    float heading = 0;
    public Transform cam;
    private bool isGrounded = true;

    [SerializeField]
    private Rigidbody rigidBody;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private bool canJump = true;

    Vector2 input;
    void FixedUpdate()

    {

        heading += Input.GetAxis("Mouse X") * Time.deltaTime * 180;

        camPivot.rotation = Quaternion.Euler(0, heading, 0);
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 1);

        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;

        camF.y = 0;
        camR.y = 0;
        camF = camF.normalized;
        camR = camR.normalized;

        rigidBody.AddForce((camF * input.y + camR * input.x) * speed);

        if(Input.GetButton("Jump") && canJump && isGrounded){
            Debug.Log("jumping");
            rigidBody.AddForce(Vector3.up * jumpForce);
        }

        //transform.position += (camF * input.y + camR * input.x) * Time.deltaTime * 5;

    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Ground")){
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision){
        if (collision.gameObject.CompareTag("Ground")){
            isGrounded = false;
        }
    }

}