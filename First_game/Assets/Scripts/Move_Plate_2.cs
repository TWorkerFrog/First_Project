using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Plate_2 : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 2f;
    private Vector3 moveVector = new Vector3(0, 0, 100);
    public GameObject plate1 = new GameObject();
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        moveVector.z = -2;
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
        if (transform.position.z <= -4)
        {
            Vector3 mV = new Vector3(0, 0, 24);
            //rb.MovePosition(mV);
            plate1.transform.position = new Vector3(0, 0, transform.position.z + 60);


        }

    }
}