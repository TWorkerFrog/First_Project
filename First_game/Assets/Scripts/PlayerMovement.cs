using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera MainCamera;
    public Vector3 Movement;
    public float jumpForce;
    private Rigidbody rb;
    public float speed;
    private bool IsJumped;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Killer"))
        {
            MainCamera.transform.parent = null;
        }

        else if (collision.gameObject.CompareTag("Ground"))
        {
            IsJumped = false;
        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Killer"))
        {
            MainCamera.transform.parent = transform;
        }
    }

    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !IsJumped) {
            IsJumped = true; 
            rb.AddForce(Vector3.up * jumpForce);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(transform.position + Vector3.left * (Time.deltaTime*speed));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(transform.position + Vector3.right * (Time.deltaTime*speed));
        }
    }
}
