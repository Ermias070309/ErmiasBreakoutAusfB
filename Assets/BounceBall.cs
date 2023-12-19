using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBall : MonoBehaviour
{
    Rigidbody myRigidbody;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.velocity = new Vector3(0, -100, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 4;
        myRigidbody.velocity = myRigidbody.velocity.normalized * speed;
        if (transform.position.y < -9)
        {
            transform.position = new Vector3(-2, -3, 0);
        }
    }
}
