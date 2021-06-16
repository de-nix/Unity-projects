using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFingerRotation : MonoBehaviour
{
    // Start is called before the first frame update
   
    private float rotationAngle;
    private int sign;
    void Start()
    {
        rotationAngle = 0;
        sign = 1;
    }
    float clamp(float a, float b, float c)
    {
        if (Math.Abs(a - b) < Math.Abs(a - c)) return b;
        return c;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0,rotationAngle,0);
        rotationAngle += sign;
        if (rotationAngle > 90 || rotationAngle < -5)
        {
            rotationAngle = clamp(rotationAngle, 90, 5);
            sign *= -1;
        }
    }
}
