using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Plate_2 : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 2f;
    public Vector3 moveVector;
    public GameObject plate1;
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        moveVector.z = -4;
        //rb.MovePosition(transform.position + speed * Time.deltaTime * Vector3.back);
        transform.position += speed * Time.deltaTime * Vector3.back;
        if (transform.position.z <= -4)
        {
            Vector3 mV = new Vector3(0, 0, 24);
            //rb.MovePosition(mV);
            plate1.transform.position = new Vector3(0, 0, transform.position.z + 60);


        }

    }
}