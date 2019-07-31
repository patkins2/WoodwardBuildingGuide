using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour
{
    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;

    [SerializeField] int speed = 20;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            mPosDelta = (Input.mousePosition - mPrevPos) * speed; 
            if (Vector3.Dot(transform.up, Vector3.up) >= 0)
            {
                transform.Rotate(transform.up, -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
            }
            else
            {
                transform.Rotate(Camera.main.transform.right, Vector3.Dot(mPosDelta, Camera.main.transform.up), Space.World);
            }
        }

        mPrevPos = Input.mousePosition;
        //transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }

  
}
