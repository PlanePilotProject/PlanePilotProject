using UnityEngine;
using System.Collections;

public class Flight : MonoBehaviour {

    public float flightSpeed = 50.0f;
    public float rotateSpeed = 25.0f;
    float fixForward = 0.0f;
    float fixRotate = 0.0f;
    void Update()
    {
        fixForward = flightSpeed * Time.deltaTime;
        fixRotate = rotateSpeed * Time.deltaTime;
        FlightControlls();
    }

	void FlightControlls()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                Debug.Log("THdown right");
                transform.Translate(0, 0, fixForward * (Input.GetAxis("Vertical") + Input.GetAxis("Vertical")));
                transform.Rotate(0, fixRotate * Input.GetAxis("Horizontal"), 0);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                Debug.Log("THdown left");
                transform.Translate(0, 0, fixForward * (Input.GetAxis("Vertical") + Input.GetAxis("Vertical")));
                transform.Rotate(0, fixRotate * Input.GetAxis("Horizontal"), 0);
            }
            else
            {
                Debug.Log("THdown");
                transform.Translate(0, 0, fixForward * (Input.GetAxis("Vertical") + Input.GetAxis("Vertical")));
            }
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                Debug.Log("THup right");
                transform.Translate(0, 0, fixForward);
                transform.Rotate(0, fixRotate * Input.GetAxis("Horizontal"), 0);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                Debug.Log("THup left");
                transform.Translate(0, 0, fixForward);
                transform.Rotate(0, fixRotate * Input.GetAxis("Horizontal"), 0);
            }
            else
            {
                Debug.Log("THup");
                transform.Translate(0, 0, fixForward);
            }
        }
        else
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                Debug.Log("THright");
                transform.Translate(0, 0, fixForward);
                transform.Rotate(0, fixRotate * Input.GetAxis("Horizontal"), 0);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                Debug.Log("THleft");
                transform.Translate(0, 0, fixForward);
                transform.Rotate(0, fixRotate * Input.GetAxis("Horizontal"), 0);
            }
            else
            {
                transform.Translate(0, 0, fixForward);
                Debug.Log("THdir idle");
            }
        }
        Debug.Log(Input.GetAxis("RVertical") + "::::" + Input.GetAxis("RHorizontal"));
        if (Input.GetAxis("RVertical") > 0)
        {
            if (Input.GetAxis("RHorizontal") > 0)
            {
                Debug.Log("down right");
                transform.Rotate(fixRotate * Input.GetAxis("RVertical"), 0, fixRotate * Input.GetAxis("RHorizontal"));
            }
            else if (Input.GetAxis("RHorizontal") < 0)
            {
                Debug.Log("down left");
                transform.Rotate(fixRotate * Input.GetAxis("RVertical"), 0, fixRotate * Input.GetAxis("RHorizontal"));
            }
            else
            {
                Debug.Log("down");
                transform.Rotate(fixRotate * Input.GetAxis("RVertical"), 0, 0);
            }
        }
        else if (Input.GetAxis("RVertical") < 0)
        {
            if (Input.GetAxis("RHorizontal") > 0)
            {
                Debug.Log("up right");
                transform.Rotate(fixRotate * Input.GetAxis("RVertical"), 0, fixRotate * Input.GetAxis("RHorizontal"));
            }
            else if (Input.GetAxis("RHorizontal") < 0)
            {
                Debug.Log("up left");
                transform.Rotate(fixRotate * Input.GetAxis("RVertical"), 0, fixRotate * Input.GetAxis("RHorizontal"));
            }
            else
            {
                Debug.Log("up");
                transform.Rotate(fixRotate * Input.GetAxis("RVertical"), 0, 0);
            }
        }
        else
        {
            if (Input.GetAxis("RHorizontal") > 0)
            {
                Debug.Log("right");
                transform.Rotate(0, 0, fixRotate * Input.GetAxis("RHorizontal"));
            }
            else if (Input.GetAxis("RHorizontal") < 0)
            {
                Debug.Log("left");
                transform.Rotate(0, 0, fixRotate * Input.GetAxis("RHorizontal"));
            }
            else
            {
                Debug.Log("dir idle");
                transform.Rotate(0, 0, 0);
            }
        }
    }
}
