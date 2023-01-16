using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private Ball ball;
    [SerializeField] private GameObject playerCamera;

    [SerializeField] private float _forwardThrowForce = 200;
    [SerializeField] private float _upwardThrowForce = 500f;

    private bool holdingBall = true;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        ball.GetComponent<Rigidbody>().useGravity = false;
    }


    void Update()
    {
        Throw();
    }

    private void Throw()
    {
        if (! holdingBall)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            holdingBall = false;
            ball.ActivateTrail();
            ball.GetComponent<Rigidbody>().useGravity = true;

            ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * _forwardThrowForce + Vector3.up * _upwardThrowForce);

            ThrowBall();
        }
    }

    private void ThrowBall()
    {
        ball.transform.parent = transform.parent;
    }
}
