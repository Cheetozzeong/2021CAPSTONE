using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class test : MonoBehaviour
{
    int headandchest_lv;
    int rightback_lv;
    int rightarm_lv;
    int leftback_lv;
    int leftarm_lv;
    int lowerbody_lv;
    int abs_lv;
    int shoulder_lv;
    public GameObject headandchest;
    public GameObject rightback;
    public GameObject rightarm;
    public GameObject leftback;
    public GameObject leftarm;
    public GameObject lowerbody;
    public GameObject abs;
    public GameObject shoulder;
    public GameObject lv3_headandchest;
    public GameObject lv3_rightback;
    public GameObject lv3_rightarm;
    public GameObject lv3_leftback;
    public GameObject lv3_leftarm;
    public GameObject lv3_lowerbody;
    public GameObject lv3_abs;
    public GameObject lv3_shoulder;
    public GameObject lv4_headandchest;
    public GameObject lv4_rightback;
    public GameObject lv4_rightarm;
    public GameObject lv4_leftback;
    public GameObject lv4_leftarm;
    public GameObject lv4_lowerbody;
    public GameObject lv4_abs;
    public GameObject lv4_shoulder;

    void Start()
    {
        
        headandchest = GameObject.Find("HeadandChest");
        rightback = GameObject.Find("RightBack");
        rightarm = GameObject.Find("RightArm");
        leftback = GameObject.Find("LeftBack");
        leftarm = GameObject.Find("LeftArm");
        lowerbody = GameObject.Find("lowerbody");
        abs = GameObject.Find("Abs");
        shoulder = GameObject.Find("3Shoulder");
        lv3_headandchest = GameObject.Find("3HeadandChest");
        lv3_rightback = GameObject.Find("3RightBack");
        lv3_rightarm = GameObject.Find("3RightArm");
        lv3_leftback = GameObject.Find("3LeftBack");
        lv3_leftarm = GameObject.Find("3LeftArm");
        lv3_lowerbody = GameObject.Find("3lowerbody");
        lv3_abs = GameObject.Find("3Abs");
        lv3_shoulder = GameObject.Find("3Shoulder");
        lv4_headandchest = GameObject.Find("4HeadandChest");
        lv4_rightback = GameObject.Find("4RightBack");
        lv4_rightarm = GameObject.Find("4RightArm");
        lv4_leftback = GameObject.Find("4LeftBack");
        lv4_leftarm = GameObject.Find("4LeftArm");
        lv4_lowerbody = GameObject.Find("4lowerbody");
        lv4_abs = GameObject.Find("4Abs");
        lv4_shoulder = GameObject.Find("4Shoulder");
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            headandchest_lv = 3;
            Set_MyCharacter();
        }
    }

    void Set_MyCharacter()
    {
        Cleaner_HeadAndChest();
        Set_HeadAndChest();
    }

    void Set_HeadAndChest()
    {
        /*if (headandchest_lv == 1) {
            Cleaner_HeadAndChest();
            if (lv1_headandchest.activeSelf == false)
                lv1_headandchest.SetActive(true);
        }
        if (headandchest_lv == 2)
        {
            Cleaner_HeadAndChest();
            if (lv2_headandchest.activeSelf == false)
                lv2_headandchest.SetActive(true);
        }*/
        if (headandchest_lv == 3)
        {
            if (lv3_headandchest.activeSelf == false)
                lv3_headandchest.SetActive(true);
        }
        else if (headandchest_lv == 4)
        {
            if (lv4_headandchest.activeSelf == false)
                lv4_headandchest.SetActive(true);
        }
    }

    void Cleaner_HeadAndChest()
    {
        if (lv4_headandchest.activeSelf == true) { 
        lv4_headandchest.SetActive(false);
    }
        if (lv3_headandchest.activeSelf == true)
        {
            lv3_headandchest.SetActive(false);
        }
    }

}