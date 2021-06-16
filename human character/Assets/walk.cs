using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class walk : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject leftKnee;
    private GameObject rightKnee;
    private GameObject rightWrist;
    private GameObject leftWrist;
    private GameObject leftLeg;
    private GameObject leftArm;
    private GameObject leftElbow;
    private GameObject rightElbow;
    private GameObject rightArm;
    private GameObject rightLeg;
    void Start()
    {
       leftKnee = GameObject.Find("LeftLeg/Knee");
       leftLeg = GameObject.Find("LeftLeg");
       leftArm = GameObject.Find("LeftArm");
       leftElbow = GameObject.Find("LeftArm/elbow");
       rightElbow = GameObject.Find("RightArm/elbow");
       rightWrist = GameObject.Find("RightArm/elbow/wrist");
       leftWrist = GameObject.Find("LeftArm/elbow/wrist");
       rightArm = GameObject.Find("RightArm");
       rightKnee = GameObject.Find("RightLeg/Knee");
       rightLeg = GameObject.Find("RightLeg");
      
    }

    private float rotationAngleLeg = 0f;
    private float rotationAngleKnee = 0f;
    private float rotationAngleElbow = 80f;
    private float rotationAngleWrist = 0f;

    private int signLeg = 1;
    private int signKnee = 1;
    private int signElbow = 1;
    private int signWrist = 1;
    // Update is called once per frame
    void Update()
    {
        leftLeg.transform.localRotation = Quaternion.Euler(rotationAngleLeg,0,0);
        rightWrist.transform.localRotation = Quaternion.Euler(0,0,rotationAngleWrist);
        leftWrist.transform.localRotation = Quaternion.Euler(0,0,rotationAngleWrist);
        leftArm.transform.localRotation = Quaternion.Euler(rotationAngleLeg,0,-80);
        rightArm.transform.localRotation = Quaternion.Euler(-rotationAngleLeg,0,80);
        rightElbow.transform.localRotation = Quaternion.Euler(-90,-rotationAngleElbow,0);
        leftElbow.transform.localRotation = Quaternion.Euler(-90,rotationAngleElbow,0);
        leftKnee.transform.localRotation = Quaternion.Euler(rotationAngleKnee,0,0);
        rightKnee.transform.localRotation = Quaternion.Euler(rotationAngleKnee,0,0);
        rightLeg.transform.localRotation = Quaternion.Euler(-rotationAngleLeg,0,0);
        rotationAngleLeg += 1f*signLeg;
        rotationAngleKnee += 1f*signKnee;
        rotationAngleElbow += 0.5f*signElbow;
        rotationAngleWrist += 0.5f*signWrist;
        
        if (rotationAngleLeg > 60  || rotationAngleLeg < -60)
        {
            rotationAngleLeg = clamp(rotationAngleLeg, 60, -60);
            signLeg *= -1;
        }

        if (rotationAngleKnee > 5 || rotationAngleKnee < -60)
        {
            rotationAngleKnee= clamp(rotationAngleKnee, 5, -60);
            signKnee *= -1;
        }
        if (rotationAngleElbow > 90 || rotationAngleElbow < 70)
        {
            rotationAngleElbow = clamp(rotationAngleElbow, 90, 70);
            signElbow *= -1;
        }
        if (rotationAngleWrist > 30 || rotationAngleWrist < -30)
        {
            rotationAngleWrist = clamp(rotationAngleWrist, 30, -30);
            signWrist *= -1;
        }

        float clamp(float a, float b, float c)
        {
            if (Math.Abs(a - b) < Math.Abs(a - c)) return b;
            return c;
        }

    }
}
