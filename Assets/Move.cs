using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody myBody;
    public float _constantMoveSpeed = 3.0f;

    Vector3 moveDirection = Vector3.zero;
    // Use this for initialization
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection.x = -1.0f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDirection.x = 1.0f;
        }
        else
        {
            moveDirection.x = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myBody.AddForce(Vector3.up * 500.0f);
        }
    }

    private void FixedUpdate()
    {
        myBody.MovePosition(transform.position + moveDirection * _constantMoveSpeed * Time.deltaTime);
    }
}
