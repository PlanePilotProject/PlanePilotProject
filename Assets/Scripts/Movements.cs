using UnityEngine;
using System.Collections;

public class Movements : MonoBehaviour {

    enum Movement
    {
        moveForward,
        moveBackward,
        moveLeft,
        moveRight,
        moveForwardLeft,
        moveForwardRight,
        moveBackwardLeft,
        moveBackwardRight,
        idle
    };
    private Movement mstate;

    public float forwardSpeed = 10.0f;
    public float backwardSpeed = 5.0f;
    public float strafeSpeed = 7.0f;
	// Update is called once per frame
	void Update () {
        DetermineDirection();
        Move();
	}

    void Move()
    {
        switch (mstate)
        {
            case Movement.moveForward:
                transform.position += transform.forward * forwardSpeed * Time.deltaTime;
                break;
            case Movement.moveForwardLeft:
                transform.position += transform.forward * forwardSpeed * Time.deltaTime;
                transform.position -= transform.right;
                break;
            case Movement.moveForwardRight:
                transform.position += transform.forward * forwardSpeed * Time.deltaTime;
                transform.position += transform.right;
                break;
            case Movement.moveBackward:
                transform.position -= transform.forward * backwardSpeed * Time.deltaTime;
                break;
            case Movement.moveBackwardLeft:
                transform.position -= transform.forward * backwardSpeed * Time.deltaTime;
                transform.position -= transform.right;
                break;
            case Movement.moveBackwardRight:
                transform.position -= transform.forward * backwardSpeed * Time.deltaTime;
                transform.position += transform.right;
                break;
            case Movement.moveRight:
                transform.position += transform.right * strafeSpeed * Time.deltaTime;
                break;
            case Movement.moveLeft:
                transform.position -= transform.right * strafeSpeed * Time.deltaTime;
                break;
            case Movement.idle:

                break;
        }
        Debug.Log(mstate);
    }

    void DetermineDirection()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                mstate = Movement.moveForwardRight;
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                mstate = Movement.moveForwardLeft;
            }
            else
            {
                mstate = Movement.moveForward;
            }
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                mstate = Movement.moveBackwardRight;
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                mstate = Movement.moveBackwardLeft;
            }
            else
            {
                mstate = Movement.moveBackward;
            }
        }
        else
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                mstate = Movement.moveRight;
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                mstate = Movement.moveLeft;
            }
            else
            {
                mstate = Movement.idle;
            }
        }
    }
}
