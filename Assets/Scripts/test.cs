using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    int A;
    int headandchest_lv;
    int back_lv;
    int arm_lv;
    int lowerbody_lv;
    int abs_lv;
    int shoulder_lv;
    int arm_shoulder_lv;
    int head_abs_lv;
    bool gender;
    public GameObject misingno;
    public GameObject man;
    public GameObject headandchest;
    public GameObject rightback;
    public GameObject rightarm;
    public GameObject leftback;
    public GameObject leftarm;
    public GameObject lowerbody;
    public GameObject abs;
    public GameObject shoulder;
    public GameObject lv1_man;
    public GameObject lv1_woman;
    public GameObject lv2_headandchest;
    public GameObject lv2_headandchestw;
    public GameObject lv2_rightback;
    public GameObject lv2_rightarm;
    public GameObject lv2_leftback;
    public GameObject lv2_leftarm;
    public GameObject lv2_lowerbody;
    public GameObject lv2_lowerbodyw;
    public GameObject lv2_abs;
    public GameObject lv2_shoulder;
    public GameObject lv3_headandchest;
    public GameObject lv3_headandchestw;
    public GameObject lv3_rightback;
    public GameObject lv3_rightarm;
    public GameObject lv3_leftback;
    public GameObject lv3_leftarm;
    public GameObject lv3_lowerbody;
    public GameObject lv3_lowerbodyw;
    public GameObject lv3_abs;
    public GameObject lv3_shoulder;
    public GameObject lv4_headandchest;
    public GameObject lv4_headandchestw;
    public GameObject lv4_rightback;
    public GameObject lv4_rightarm;
    public GameObject lv4_leftback;
    public GameObject lv4_leftarm;
    public GameObject lv4_lowerbody;
    public GameObject lv4_lowerbodyw;
    public GameObject lv4_abs;
    public GameObject lv4_shoulder;
    Transform ps_lv1_man;
    Transform ps_lv1_woman;
    Transform ps_lv2_headandchest;
    Transform ps_lv2_headandchestw;
    Transform ps_lv2_rightback;
    Transform ps_lv2_rightarm;
    Transform ps_lv2_leftback;
    Transform ps_lv2_leftarm;
    Transform ps_lv2_lowerbody;
    Transform ps_lv2_lowerbodyw;
    Transform ps_lv2_abs;
    Transform ps_lv2_shoulder;
    Transform ps_lv3_headandchest;
    Transform ps_lv3_headandchestw;
    Transform ps_lv3_rightback;
    Transform ps_lv3_rightarm;
    Transform ps_lv3_leftback;
    Transform ps_lv3_leftarm;
    Transform ps_lv3_lowerbody;
    Transform ps_lv3_lowerbodyw;
    Transform ps_lv3_abs;
    Transform ps_lv3_shoulder;
    Transform ps_lv4_headandchest;
    Transform ps_lv4_headandchestw;
    Transform ps_lv4_rightback;
    Transform ps_lv4_rightarm;
    Transform ps_lv4_leftback;
    Transform ps_lv4_leftarm;
    Transform ps_lv4_lowerbody;
    Transform ps_lv4_lowerbodyw;
    Transform ps_lv4_abs;
    Transform ps_lv4_shoulder;

    void Start()
    {
        misingno = GameObject.Find("misingno");
        man = GameObject.Find("Man");
        headandchest = GameObject.Find("HeadandChest");
        rightback = GameObject.Find("RightBack");
        rightarm = GameObject.Find("RightArm");
        leftback = GameObject.Find("LeftBack");
        leftarm = GameObject.Find("LeftArm");
        lowerbody = GameObject.Find("lowerbody");
        abs = GameObject.Find("Abs");
        shoulder = GameObject.Find("Shoulder");
        lv1_man = GameObject.Find("man1");
        lv1_woman = GameObject.Find("woman1");
        lv2_headandchest = GameObject.Find("2HeadandChest");
        lv2_headandchestw = GameObject.Find("2HeadandChestW");
        lv2_rightback = GameObject.Find("2RightBack");
        lv2_rightarm = GameObject.Find("2RightArm");
        lv2_leftback = GameObject.Find("2LeftBack");
        lv2_leftarm = GameObject.Find("2LeftArm");
        lv2_lowerbody = GameObject.Find("2lowerbody");
        lv2_lowerbodyw = GameObject.Find("2lowerbodyW");
        lv2_abs = GameObject.Find("2Abs");
        lv2_shoulder = GameObject.Find("2Shoulder");
        lv3_headandchest = GameObject.Find("3HeadandChest");
        lv3_headandchestw = GameObject.Find("3HeadandChestW");
        lv3_rightback = GameObject.Find("3RightBack");
        lv3_rightarm = GameObject.Find("3RightArm");
        lv3_leftback = GameObject.Find("3LeftBack");
        lv3_leftarm = GameObject.Find("3LeftArm");
        lv3_lowerbody = GameObject.Find("3lowerbody");
        lv3_lowerbodyw = GameObject.Find("3lowerbodyW");
        lv3_abs = GameObject.Find("3Abs");
        lv3_shoulder = GameObject.Find("3Shoulder");
        lv4_headandchest = GameObject.Find("4HeadandChest");
        lv4_headandchestw = GameObject.Find("4HeadandChestW");
        lv4_rightback = GameObject.Find("4RightBack");
        lv4_rightarm = GameObject.Find("4RightArm");
        lv4_leftback = GameObject.Find("4LeftBack");
        lv4_leftarm = GameObject.Find("4LeftArm");
        lv4_lowerbody = GameObject.Find("4lowerbody");
        lv4_lowerbodyw = GameObject.Find("4lowerbodyW");
        lv4_abs = GameObject.Find("4Abs");
        lv4_shoulder = GameObject.Find("4Shoulder");
        ps_lv1_man = lv1_man.GetComponent<Transform>();
        ps_lv1_woman = lv1_woman.GetComponent<Transform>();
        ps_lv2_headandchest = lv2_headandchest.GetComponent<Transform>();
        ps_lv2_headandchestw = lv2_headandchestw.GetComponent<Transform>();
        ps_lv2_rightback = lv2_rightback.GetComponent<Transform>();
        ps_lv2_rightarm = lv2_rightarm.GetComponent<Transform>();
        ps_lv2_leftback = lv2_leftback.GetComponent<Transform>();
        ps_lv2_leftarm = lv2_leftarm.GetComponent<Transform>();
        ps_lv2_lowerbody = lv2_lowerbody.GetComponent<Transform>();
        ps_lv2_lowerbodyw = lv2_lowerbodyw.GetComponent<Transform>();
        ps_lv2_abs = lv2_abs.GetComponent<Transform>();
        ps_lv2_shoulder = lv2_shoulder.GetComponent<Transform>();
        ps_lv3_headandchest = lv3_headandchest.GetComponent<Transform>();
        ps_lv3_headandchestw = lv3_headandchestw.GetComponent<Transform>();
        ps_lv3_rightback = lv3_rightback.GetComponent<Transform>();
        ps_lv3_rightarm = lv3_rightarm.GetComponent<Transform>();
        ps_lv3_leftback = lv3_leftback.GetComponent<Transform>();
        ps_lv3_leftarm = lv3_leftarm.GetComponent<Transform>();
        ps_lv3_lowerbody = lv3_lowerbody.GetComponent<Transform>();
        ps_lv3_lowerbodyw = lv3_lowerbodyw.GetComponent<Transform>();
        ps_lv3_abs = lv3_abs.GetComponent<Transform>();
        ps_lv3_shoulder = lv3_shoulder.GetComponent<Transform>();
        ps_lv4_headandchest = lv4_headandchest.GetComponent<Transform>();
        ps_lv4_headandchestw = lv4_headandchestw.GetComponent<Transform>();
        ps_lv4_rightback = lv4_rightback.GetComponent<Transform>();
        ps_lv4_rightarm = lv4_rightarm.GetComponent<Transform>();
        ps_lv4_leftback = lv4_leftback.GetComponent<Transform>();
        ps_lv4_leftarm = lv4_leftarm.GetComponent<Transform>();
        ps_lv4_lowerbody = lv4_lowerbody.GetComponent<Transform>();
        ps_lv4_lowerbodyw = lv4_lowerbodyw.GetComponent<Transform>();
        ps_lv4_abs = lv4_abs.GetComponent<Transform>();
        ps_lv4_shoulder = lv4_shoulder.GetComponent<Transform>();
        A = 0;

    }


    void Update()
    {
        if (A <= headandchest_lv)
        {
            Checker();
            arm_shoulder_lv = arm_lv + shoulder_lv;
            head_abs_lv = headandchest_lv + abs_lv;
            Set_MyCharacter();
            A++;
        }

    }
    void Set_Position_body()
    {
        if (gender == true) //남,여 구분
        {
            if (head_abs_lv >= 4 && head_abs_lv < 6 && arm_shoulder_lv >= 4 && arm_shoulder_lv < 6)
            {
                if (back_lv == 2)
                {
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbody.position = new Vector3(-2.55f, -0.176f, 0);
                    }
                }
                if (back_lv == 3)
                {
                    ps_lv3_rightback.position = new Vector3(-2.4f, 0.15f, 0f);
                    ps_lv3_leftback.position = new Vector3(-2.57f, 0.219f, 0f);
                    ps_lv3_leftback.eulerAngles = new Vector3(0, -2.6f, 0);
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbody.position = new Vector3(-2.55f, -0.176f, 0);
                    }
                }
                if (back_lv == 4)
                {
                    ps_lv4_rightback.position = new Vector3(-5.7f, 1.5f, 0f);
                    ps_lv4_leftback.position = new Vector3(-2.72f, -0.15f, 0f);
                    ps_lv4_rightback.eulerAngles = new Vector3(-8, 2.5f, 0);
                    ps_lv4_leftback.eulerAngles = new Vector3(0, -2.1f, 0);
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbody.position = new Vector3(-2.55f, -0.176f, 0);
                    }
                }
            } //몸팔이 전부 2단계
            if (head_abs_lv >= 4 && head_abs_lv < 6 && arm_shoulder_lv >= 6 && arm_shoulder_lv < 8)
            {
                ps_lv3_rightarm.position = new Vector3(-2.445f, 0.055f, 0f);
                ps_lv3_leftarm.position = new Vector3(-2.65f, 0.2f, 0);
                ps_lv3_shoulder.position = new Vector3(-2.65f, 0.134f, 0);
                if (back_lv == 2)
                {
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbody.position = new Vector3(-2.55f, -0.176f, 0);
                    }
                }
                if (back_lv == 3)
                {
                    ps_lv3_rightback.position = new Vector3(-2.4f, 0.15f, 0f);
                    ps_lv3_leftback.position = new Vector3(-2.57f, 0.219f, 0f);
                    ps_lv3_leftback.eulerAngles = new Vector3(0, -2.6f, 0);
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbody.position = new Vector3(-2.55f, -0.176f, 0);
                    }

                }
                if (back_lv == 4)
                {
                    ps_lv4_rightback.position = new Vector3(-5.7f, 1.5f, 0f);
                    ps_lv4_leftback.position = new Vector3(-2.72f, -0.15f, 0f);
                    ps_lv4_rightback.eulerAngles = new Vector3(-8, 2.5f, 0);
                    ps_lv4_leftback.eulerAngles = new Vector3(0, -2.1f, 0);
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbody.position = new Vector3(-2.55f, -0.176f, 0);
                    }
                }
            } //몸은 2단계 팔은 3단계
            if (head_abs_lv >= 4 && head_abs_lv < 6 && arm_shoulder_lv >= 8)
            {
                ps_lv4_rightarm.position = new Vector3(-2.428f, -0.4f, 0f);
                ps_lv4_shoulder.position = new Vector3(-2.83f, -0.19f, 0); // 숫자가 커지면 오른쪽으로
                ps_lv4_leftarm.position = new Vector3(-2.69f, -0.2f, 0);
                ps_lv4_shoulder.eulerAngles = new Vector3(0, -1.5f, 0);
                if (back_lv == 2)
                {
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbody.position = new Vector3(-2.55f, -0.176f, 0);
                    }
                }
                if (back_lv == 3)
                {
                    ps_lv3_rightback.position = new Vector3(-2.4f, 0.15f, 0f);
                    ps_lv3_leftback.position = new Vector3(-2.57f, 0.28f, 0f);
                    ps_lv3_leftback.eulerAngles = new Vector3(0, -3f, 0);
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbodyw.position = new Vector3(-2.55f, -0.176f, 0);
                    }

                }//등이 3단계
                if (back_lv == 4)
                {
                    ps_lv4_rightback.position = new Vector3(-5.7f, 1.5f, 0f);
                    ps_lv4_leftback.position = new Vector3(-2.72f, -0.15f, 0f);
                    ps_lv4_rightback.eulerAngles = new Vector3(-8, 2.5f, 0);
                    ps_lv4_leftback.eulerAngles = new Vector3(0, -2.1f, 0);
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbody.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbodyw.position = new Vector3(-2.55f, -0.176f, 0);
                    }
                }//등이 4단계

            } // 몸은 2단계 팔은 4단계
            if (head_abs_lv >= 6 && head_abs_lv < 8 && arm_shoulder_lv >= 4 && arm_shoulder_lv < 6)
            {
                ps_lv2_rightarm.position = new Vector3(0.325f, 0.23f, 0f);
                ps_lv2_leftarm.position = new Vector3(0.55f, 0.15f, 0);
                ps_lv2_leftarm.localScale = new Vector3(1f, 1, 1);
                ps_lv2_shoulder.position = new Vector3(0.55f, 0.15f, 0);
                if (back_lv == 2)
                {
                    ps_lv2_rightback.position = new Vector3(0.28f, 0.15f, 0f);
                    ps_lv2_leftback.position = new Vector3(0.53f, 0.08f, 0f);
                    ps_lv2_leftback.eulerAngles = new Vector3(0, 5f, -5f);
                    if (lowerbody_lv == 2)
                    {
                        ps_lv2_lowerbody.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbody.position = new Vector3(-2.6f, -0.33f, 0);
                    }

                }//등이 2단계
                if (back_lv == 3) 
                {
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbody.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbody.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }
                if (back_lv == 4)
                {
                    ps_lv4_rightback.position = new Vector3(-5.8f, 1.5f, 0f);
                    ps_lv4_leftback.position = new Vector3(-2.71f, -0.2f, 0f);
                    ps_lv4_rightback.eulerAngles = new Vector3(0, 0, 0);
                    ps_lv4_leftback.eulerAngles = new Vector3(0, 0, 0);
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbody.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbody.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }//등이 4단계

            } // 몸은 3단계 팔은 2단계
            if (head_abs_lv >= 6 && head_abs_lv < 8 && arm_shoulder_lv >= 6 && arm_shoulder_lv < 8) 
            {
                if (back_lv == 2)
                {
                    ps_lv2_rightback.position = new Vector3(0.28f, 0.15f, 0f);
                    ps_lv2_leftback.position = new Vector3(0.53f, 0.08f, 0f);
                    ps_lv2_leftback.eulerAngles = new Vector3(0, 5f, -5f);
                    if (lowerbody_lv == 2)
                    {
                        ps_lv2_lowerbody.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbody.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }
                if (back_lv == 3)
                {
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbody.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbody.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }
                if (back_lv == 4)
                {
                    ps_lv4_rightback.position = new Vector3(-5.8f, 1.5f, 0f);
                    ps_lv4_leftback.position = new Vector3(-2.71f, -0.2f, 0f);
                    ps_lv4_rightback.eulerAngles = new Vector3(0, 0, 0);
                    ps_lv4_leftback.eulerAngles = new Vector3(0, 0, 0);
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbody.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbody.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }
            }//몸팔이 전부 3단계
            if (head_abs_lv >= 6 && head_abs_lv < 8 && arm_shoulder_lv >= 8)
            {
                ps_lv4_rightarm.position = new Vector3(-2.52f, -0.45f, 0f);
                ps_lv4_leftarm.position = new Vector3(-2.65f, -0.12f, 0);
                ps_lv4_shoulder.position = new Vector3(-2.65f, -0.12f, 0);
                if (back_lv == 2)
                {
                    ps_lv2_rightback.position = new Vector3(0.28f, 0.15f, 0f);
                    ps_lv2_leftback.position = new Vector3(0.53f, 0.08f, 0f);
                    ps_lv2_leftback.eulerAngles = new Vector3(0, 5f, -5f);
                    if (lowerbody_lv == 2)
                    {
                        ps_lv2_lowerbody.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbody.position = new Vector3(-2.6f, -0.33f, 0);
                    }

                }//등이 2단계
                if (back_lv == 3)
                {
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbody.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbody.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }
                if (back_lv == 4)
                {
                    ps_lv4_rightback.position = new Vector3(-5.8f, 1.5f, 0f);
                    ps_lv4_leftback.position = new Vector3(-2.71f, -0.2f, 0f);
                    ps_lv4_rightback.eulerAngles = new Vector3(0, 0, 0);
                    ps_lv4_leftback.eulerAngles = new Vector3(0, 0, 0);
                    if (lowerbody_lv == 3)
                    {

                        ps_lv2_lowerbody.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbody.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }//등이 4단계

            } // 몸은 3단계 팔은 4단계
            if (head_abs_lv >= 8 && arm_shoulder_lv >= 4 && arm_shoulder_lv < 6)
            {
                ps_lv2_rightarm.position = new Vector3(0.19f, 0.3f, 0f);
                ps_lv2_leftarm.position = new Vector3(0.58f, 0.27f, 0);
                ps_lv2_shoulder.position = new Vector3(0.58f, 0.27f, 0);
                if (back_lv == 2)
                {
                    ps_lv2_rightback.position = new Vector3(0.59f, 0.15f, 0f);
                    ps_lv2_rightback.localScale = new Vector3(1.3f, 1.3f, 1);
                    ps_lv2_leftback.position = new Vector3(0.85f, 0.12f, 0f);
                    ps_lv2_leftback.localScale = new Vector3(1.3f, 1.3f, 1);
                    ps_lv2_leftback.eulerAngles = new Vector3(0, 5f, -7f);
                    if (lowerbody_lv == 2)
                    {
                        ps_lv2_lowerbody.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbody.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.72f, -0.002f, 0);
                    }

                }//등이 2단계
                if (back_lv == 3)
                {
                    ps_lv3_rightback.position = new Vector3(-2.56f, -0.12f, 0f);
                    ps_lv3_leftback.position = new Vector3(-2.48f, 0.05f, 0f);
                    ps_lv3_rightback.eulerAngles = new Vector3(0, 0, 0);
                    ps_lv3_leftback.eulerAngles = new Vector3(0, 0, 0);
                    if (lowerbody_lv == 3)
                    {

                        ps_lv2_lowerbody.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {

                        ps_lv3_lowerbody.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.72f, -0.002f, 0);
                    }
                }//등이 3단계
                if (back_lv == 4)
                {
                    if (lowerbody_lv == 3)
                    {

                        ps_lv2_lowerbody.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {

                        ps_lv3_lowerbody.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.72f, -0.002f, 0);
                    }
                }

            } // 몸은 4단계 팔은 2단계
            if (head_abs_lv >= 8 && arm_shoulder_lv >= 6 && arm_shoulder_lv < 8)
            {

                ps_lv3_rightarm.position = new Vector3(-2.63f, 0.05f, 0f);
                ps_lv3_leftarm.position = new Vector3(-3.3f, 0.18f, 0f);
                ps_lv3_leftarm.localScale = new Vector3(1.3f, 1.3f, 1);
                ps_lv3_shoulder.position = new Vector3(-2.4795f, 0.149f, 0f);
                if (back_lv == 2)
                {
                    ps_lv2_rightback.position = new Vector3(0.59f, 0.15f, 0f);
                    ps_lv2_rightback.localScale = new Vector3(1.3f, 1.3f, 1);
                    ps_lv2_leftback.position = new Vector3(0.85f, 0.12f, 0f);
                    ps_lv2_leftback.localScale = new Vector3(1.3f, 1.3f, 1);
                    ps_lv2_leftback.eulerAngles = new Vector3(0, 5f, -7f);
                    if (lowerbody_lv == 2)
                    {
                        ps_lv2_lowerbody.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbody.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.72f, -0.002f, 0);
                    }

                }//등이 2단계
                if (back_lv == 3)
                {
                    ps_lv3_rightback.position = new Vector3(-2.56f, -0.12f, 0f);
                    ps_lv3_leftback.position = new Vector3(-2.48f, 0.12f, 0f);
                    ps_lv3_rightback.eulerAngles = new Vector3(0, 0, 0);
                    ps_lv3_leftback.eulerAngles = new Vector3(0, 0, -0.5f);
                    if (lowerbody_lv == 3)
                    {

                        ps_lv2_lowerbody.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {

                        ps_lv3_lowerbody.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.72f, -0.002f, 0);
                    }
                }//등이 3단계
                if (back_lv == 4)
                {
                    if (lowerbody_lv == 3)
                    {

                        ps_lv2_lowerbody.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {

                        ps_lv3_lowerbody.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.72f, -0.002f, 0);
                    }
                }
            } // 몸은 4단계 팔은 3단계
            if (head_abs_lv >= 8 && arm_shoulder_lv >= 8)
            {
                if (back_lv == 2)
                {
                    ps_lv2_rightback.position = new Vector3(0.59f, 0.15f, 0f);
                    ps_lv2_rightback.localScale = new Vector3(1.3f, 1.3f, 1);
                    ps_lv2_leftback.position = new Vector3(0.85f, 0.12f, 0f);
                    ps_lv2_leftback.localScale = new Vector3(1.3f, 1.3f, 1);
                    ps_lv2_leftback.eulerAngles = new Vector3(0, 5f, -7f);
                    if (lowerbody_lv == 2)
                    {
                        ps_lv2_lowerbody.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbody.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.72f, -0.002f, 0);
                    }

                }//등이 2단계
                if (back_lv == 3)
                {
                    ps_lv3_rightback.position = new Vector3(-2.56f, -0.12f, 0f);
                    ps_lv3_leftback.position = new Vector3(-2.48f, 0.12f, 0f);
                    ps_lv3_rightback.eulerAngles = new Vector3(0, 0, 0);
                    ps_lv3_leftback.eulerAngles = new Vector3(0, 0, -0.5f);
                    if (lowerbody_lv == 3)
                    {

                        ps_lv2_lowerbody.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {

                        ps_lv3_lowerbody.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.72f, -0.002f, 0);
                    }
                }//등이 3단계
                if (back_lv == 4)
                {
                    if (lowerbody_lv == 3)
                    {

                        ps_lv2_lowerbody.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbody.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {

                        ps_lv3_lowerbody.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbody.position = new Vector3(-2.72f, -0.002f, 0);
                    }
                }
            }//몸팔이 전부 4단계
        }
        if (gender == false) //남,여 구분
        {
            if (head_abs_lv >= 4 && head_abs_lv < 6 && arm_shoulder_lv >= 4 && arm_shoulder_lv < 6)
            {
                if (back_lv == 2)
                {
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbodyw.position = new Vector3(-2.55f, -0.176f, 0);
                    }

                }
                if (back_lv == 3)
                {
                    ps_lv3_rightback.position = new Vector3(-2.4f, 0.15f, 0f);
                    ps_lv3_leftback.position = new Vector3(-2.57f, 0.219f, 0f);
                    ps_lv3_leftback.eulerAngles = new Vector3(0, -2.6f, 0);
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbodyw.position = new Vector3(-2.55f, -0.176f, 0);
                    }

                }//등이 3단계
                if (back_lv == 4)
                {
                    ps_lv4_rightback.position = new Vector3(-5.7f, 1.5f, 0f);
                    ps_lv4_leftback.position = new Vector3(-2.72f, -0.15f, 0f);
                    ps_lv4_rightback.eulerAngles = new Vector3(-8, 2.5f, 0);
                    ps_lv4_leftback.eulerAngles = new Vector3(0, -2.1f, 0);
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbodyw.position = new Vector3(-2.55f, -0.176f, 0);
                    }
                }//등이 4단계
            }//몸팔이 전부 2단계
            if (head_abs_lv >= 4 && head_abs_lv < 6 && arm_shoulder_lv >= 6 && arm_shoulder_lv < 8)
            {
                ps_lv3_rightarm.position = new Vector3(-2.445f, 0.055f, 0f);
                ps_lv3_leftarm.position = new Vector3(-2.65f, 0.2f, 0);
                ps_lv3_shoulder.position = new Vector3(-2.65f, 0.134f, 0);
                if (back_lv == 2)
                {
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbodyw.position = new Vector3(-2.55f, -0.176f, 0);
                    }

                }
                if (back_lv == 3)
                {
                    ps_lv3_rightback.position = new Vector3(-2.4f, 0.15f, 0f);
                    ps_lv3_leftback.position = new Vector3(-2.57f, 0.219f, 0f);
                    ps_lv3_leftback.eulerAngles = new Vector3(0, -2.6f, 0);
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbodyw.position = new Vector3(-2.55f, -0.176f, 0);
                    }

                }//등이 3단계
                if (back_lv == 4)
                {
                    ps_lv4_rightback.position = new Vector3(-5.7f, 1.5f, 0f);
                    ps_lv4_leftback.position = new Vector3(-2.72f, -0.15f, 0f);
                    ps_lv4_rightback.eulerAngles = new Vector3(-8, 2.5f, 0);
                    ps_lv4_leftback.eulerAngles = new Vector3(0, -2.1f, 0);
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbodyw.position = new Vector3(-2.55f, -0.176f, 0);
                    }
                }//등이 4단계
            } //몸은 2단계 팔은 3단계
            if (head_abs_lv >= 4 && head_abs_lv < 6 && arm_shoulder_lv >= 8)
            {
                ps_lv4_rightarm.position = new Vector3(-2.428f, -0.4f, 0f);
                ps_lv4_shoulder.position = new Vector3(-2.83f, -0.19f, 0); // 숫자가 커지면 오른쪽으로
                ps_lv4_leftarm.position = new Vector3(-2.69f, -0.2f, 0);
                ps_lv4_shoulder.eulerAngles = new Vector3(0, -1.5f, 0);
                if (back_lv == 2)
                {
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbodyw.position = new Vector3(-2.55f, -0.176f, 0);
                    }
                }
                if (back_lv == 3)
                {
                    ps_lv3_rightback.position = new Vector3(-2.4f, 0.15f, 0f);
                    ps_lv3_leftback.position = new Vector3(-2.57f, 0.28f, 0f);
                    ps_lv3_leftback.eulerAngles = new Vector3(0, -3f, 0);
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbodyw.position = new Vector3(-2.55f, -0.176f, 0);
                    }

                }//등이 3단계
                if (back_lv == 4)
                {
                    ps_lv4_rightback.position = new Vector3(-5.7f, 1.5f, 0f);
                    ps_lv4_leftback.position = new Vector3(-2.72f, -0.15f, 0f);
                    ps_lv4_rightback.eulerAngles = new Vector3(-8, 2.5f, 0);
                    ps_lv4_leftback.eulerAngles = new Vector3(0, -2.1f, 0);
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(-2.47f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {
                        ps_lv4_lowerbodyw.localScale = new Vector3(1f, 1, 1);
                        ps_lv4_lowerbodyw.position = new Vector3(-2.55f, -0.176f, 0);
                    }
                }//등이 4단계

            } // 몸은 2단계 팔은 4단계
            if (head_abs_lv >= 6 && head_abs_lv < 8 && arm_shoulder_lv >= 4 && arm_shoulder_lv < 6)
            {
                ps_lv2_rightarm.position = new Vector3(0.325f, 0.23f, 0f);
                ps_lv2_leftarm.position = new Vector3(0.55f, 0.15f, 0);
                ps_lv2_leftarm.localScale = new Vector3(1f, 1, 1);
                ps_lv2_shoulder.position = new Vector3(0.55f, 0.15f, 0);
                if (back_lv == 2)
                {
                    ps_lv2_rightback.position = new Vector3(0.28f, 0.15f, 0f);
                    ps_lv2_leftback.position = new Vector3(0.53f, 0.08f, 0f);
                    ps_lv2_leftback.eulerAngles = new Vector3(0, 5f, -5f);
                    if (lowerbody_lv == 2)
                    {
                        ps_lv2_lowerbodyw.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbodyw.position = new Vector3(-2.6f, -0.33f, 0);
                    }

                }//등이 2단계
                if (back_lv == 3)
                {
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbodyw.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbodyw.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }
                if (back_lv == 4)
                {
                    ps_lv4_rightback.position = new Vector3(-5.8f, 1.5f, 0f);
                    ps_lv4_leftback.position = new Vector3(-2.71f, -0.2f, 0f);
                    ps_lv4_rightback.eulerAngles = new Vector3(0, 0, 0);
                    ps_lv4_leftback.eulerAngles = new Vector3(0, 0, 0);
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbodyw.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbodyw.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }//등이 4단계

            } // 몸은 3단계 팔은 2단계
            if (head_abs_lv >= 6 && head_abs_lv < 8 && arm_shoulder_lv >= 6 && arm_shoulder_lv < 8)
            {
                if (back_lv == 2)
                {
                    ps_lv2_rightback.position = new Vector3(0.28f, 0.15f, 0f);
                    ps_lv2_leftback.position = new Vector3(0.53f, 0.08f, 0f);
                    ps_lv2_leftback.eulerAngles = new Vector3(0, 5f, -5f);
                    if (lowerbody_lv == 2)
                    {
                        ps_lv2_lowerbodyw.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbodyw.position = new Vector3(-2.6f, -0.33f, 0);
                    }

                }//등이 2단계
                if (back_lv == 3)
                {
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbodyw.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbodyw.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }
                if (back_lv == 4)
                {
                    ps_lv4_rightback.position = new Vector3(-5.8f, 1.5f, 0f);
                    ps_lv4_leftback.position = new Vector3(-2.71f, -0.2f, 0f);
                    ps_lv4_rightback.eulerAngles = new Vector3(0, 0, 0);
                    ps_lv4_leftback.eulerAngles = new Vector3(0, 0, 0);
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbodyw.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbodyw.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }//등이 4단계
            }
            if (head_abs_lv >= 6 && head_abs_lv < 8 && arm_shoulder_lv >= 8)
            {
                ps_lv4_rightarm.position = new Vector3(-2.52f, -0.45f, 0f);
                ps_lv4_leftarm.position = new Vector3(-2.65f, -0.12f, 0);
                ps_lv4_shoulder.position = new Vector3(-2.65f, -0.12f, 0);
                if (back_lv == 2)
                {
                    ps_lv2_rightback.position = new Vector3(0.28f, 0.15f, 0f);
                    ps_lv2_leftback.position = new Vector3(0.53f, 0.08f, 0f);
                    ps_lv2_leftback.eulerAngles = new Vector3(0, 5f, -5f);
                    if (lowerbody_lv == 2)
                    {
                        ps_lv2_lowerbodyw.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbodyw.position = new Vector3(-2.6f, -0.33f, 0);
                    }

                }//등이 2단계
                if (back_lv == 3)
                {
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbodyw.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbodyw.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }
                if (back_lv == 4)
                {
                    ps_lv4_rightback.position = new Vector3(-5.8f, 1.5f, 0f);
                    ps_lv4_leftback.position = new Vector3(-2.71f, -0.2f, 0f);
                    ps_lv4_rightback.eulerAngles = new Vector3(0, 0, 0);
                    ps_lv4_leftback.eulerAngles = new Vector3(0, 0, 0);
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbodyw.localScale = new Vector3(1.2f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.53f, 0.09f, 0);
                    }
                    if (lowerbody_lv == 4)
                    {

                        ps_lv4_lowerbodyw.position = new Vector3(-2.6f, -0.33f, 0);
                    }
                }//등이 4단계

            } // 몸은 3단계 팔은 4단계
            if (head_abs_lv >= 8 && arm_shoulder_lv >= 4 && arm_shoulder_lv < 6)
            {
                ps_lv2_rightarm.position = new Vector3(0.19f, 0.3f, 0f);
                ps_lv2_leftarm.position = new Vector3(0.58f, 0.27f, 0);
                ps_lv2_shoulder.position = new Vector3(0.58f, 0.27f, 0);
                if (back_lv == 2)
                {
                    ps_lv2_rightback.position = new Vector3(0.59f, 0.15f, 0f);
                    ps_lv2_rightback.localScale = new Vector3(1.3f, 1.3f, 1);
                    ps_lv2_leftback.position = new Vector3(0.85f, 0.12f, 0f);
                    ps_lv2_leftback.localScale = new Vector3(1.3f, 1.3f, 1);
                    ps_lv2_leftback.eulerAngles = new Vector3(0, 5f, -7f);

                    if (lowerbody_lv == 2)
                    {
                        ps_lv2_lowerbodyw.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(0.55f, 0.18f, 0);
                    }

                }//등이 2단계
                if (back_lv == 3)
                {
                    ps_lv3_rightback.position = new Vector3(-2.56f, -0.12f, 0f);
                    ps_lv3_leftback.position = new Vector3(-2.48f, 0.05f, 0f);
                    ps_lv3_rightback.eulerAngles = new Vector3(0, 0, 0);
                    ps_lv3_leftback.eulerAngles = new Vector3(0, 0, 0);
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbodyw.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {

                        ps_lv3_lowerbodyw.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(0.55f, 0.18f, 0);
                    }
                }//등이 3단계
                if (back_lv == 4)
                {
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbodyw.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {

                        ps_lv3_lowerbodyw.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(0.55f, 0.18f, 0);
                    }
                }

            } // 몸은 4단계 팔은 2단계
            if (head_abs_lv >= 8 && arm_shoulder_lv >= 6 && arm_shoulder_lv < 8)
            {

                ps_lv3_rightarm.position = new Vector3(-2.63f, 0.05f, 0f);
                ps_lv3_leftarm.position = new Vector3(-3.3f, 0.18f, 0f);
                ps_lv3_leftarm.localScale = new Vector3(1.3f, 1.3f, 1);
                ps_lv3_shoulder.position = new Vector3(-2.4795f, 0.149f, 0f);
                if (back_lv == 2)
                {
                    ps_lv2_rightback.position = new Vector3(0.59f, 0.15f, 0f);
                    ps_lv2_rightback.localScale = new Vector3(1.3f, 1.3f, 1);
                    ps_lv2_leftback.position = new Vector3(0.85f, 0.12f, 0f);
                    ps_lv2_leftback.localScale = new Vector3(1.3f, 1.3f, 1);
                    ps_lv2_leftback.eulerAngles = new Vector3(0, 5f, -7f);
                    if (lowerbody_lv == 2)
                    {
                        ps_lv2_lowerbodyw.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(0.55f, 0.18f, 0);
                    }

                }//등이 2단계
                if (back_lv == 3)
                {
                    ps_lv3_rightback.position = new Vector3(-2.56f, -0.12f, 0f);
                    ps_lv3_leftback.position = new Vector3(-2.48f, 0.12f, 0f);
                    ps_lv3_rightback.eulerAngles = new Vector3(0, 0, 0);
                    ps_lv3_leftback.eulerAngles = new Vector3(0, 0, -0.5f);
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbodyw.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {

                        ps_lv3_lowerbodyw.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(0.55f, 0.18f, 0);
                    }
                }//등이 3단계
                if (back_lv == 4)
                {
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbodyw.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(0.55f, 0.18f, 0);
                    }
                }

            } // 몸은 4단계 팔은 3단계
            if (head_abs_lv >= 8 && arm_shoulder_lv >= 8)
            {
                if (back_lv == 2)
                {
                    ps_lv2_rightback.position = new Vector3(0.59f, 0.15f, 0f);
                    ps_lv2_rightback.localScale = new Vector3(1.3f, 1.3f, 1);
                    ps_lv2_leftback.position = new Vector3(0.85f, 0.12f, 0f);
                    ps_lv2_leftback.localScale = new Vector3(1.3f, 1.3f, 1);
                    ps_lv2_leftback.eulerAngles = new Vector3(0, 5f, -7f);
                    if (lowerbody_lv == 2)
                    {
                        ps_lv2_lowerbodyw.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {
                        ps_lv3_lowerbodyw.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(0.55f, 0.18f, 0);
                    }

                }//등이 2단계
                if (back_lv == 3)
                {
                    ps_lv3_rightback.position = new Vector3(-2.56f, -0.12f, 0f);
                    ps_lv3_leftback.position = new Vector3(-2.48f, 0.12f, 0f);
                    ps_lv3_rightback.eulerAngles = new Vector3(0, 0, 0);
                    ps_lv3_leftback.eulerAngles = new Vector3(0, 0, -0.5f);
                    if (lowerbody_lv == 2)
                    {

                        ps_lv3_lowerbodyw.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(0.55f, 0.18f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {

                        ps_lv3_lowerbodyw.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(0.55f, 0.18f, 0);
                    }
                }//등이 3단계
                if (back_lv == 4)
                {
                    if (lowerbody_lv == 2)
                    {

                        ps_lv2_lowerbodyw.localScale = new Vector3(1.5f, 1, 1);
                        ps_lv2_lowerbodyw.position = new Vector3(0.8f, 0.05f, 0);
                    }
                    if (lowerbody_lv == 3)
                    {

                        ps_lv3_lowerbodyw.localScale = new Vector3(1.1f, 1, 1);
                        ps_lv3_lowerbodyw.position = new Vector3(-2.72f, -0.002f, 0);
                    }
                }
            }// 몸팔이 전부 4단계
        }
    }
    void Set_MyCharacter()
    {
            if (headandchest_lv == 1)
            {
                Clean_All();
                Set_HeadAndAbs();


            }
            else
            {
                Clean_All();
                Set_All();
            }
        }
    void Set_HeadAndAbs()
    {
        if (head_abs_lv >= 4 && head_abs_lv < 6 && gender == true)
        {
            if (lv2_headandchest.activeSelf == false)
                lv2_headandchest.SetActive(true);
            if (lv2_abs.activeSelf == false)
                lv2_abs.SetActive(true);
        }
        if (head_abs_lv >= 4 && head_abs_lv < 6 && gender == false)
        {
            if (lv2_headandchestw.activeSelf == false)
                lv2_headandchestw.SetActive(true);
            if (lv2_abs.activeSelf == false)
                lv2_abs.SetActive(true);
        }
        if (head_abs_lv >= 6 && head_abs_lv < 8 && gender == true)
        {
            if (lv3_headandchest.activeSelf == false)
                lv3_headandchest.SetActive(true);
            if (lv3_abs.activeSelf == false)
                lv3_abs.SetActive(true);
        }
        if (head_abs_lv >= 6 && head_abs_lv < 8 && gender == false)
        {
            if (lv3_headandchestw.activeSelf == false)
                lv3_headandchestw.SetActive(true);
            if (lv3_abs.activeSelf == false)
                lv3_abs.SetActive(true);
        }
        if (head_abs_lv >= 8 && gender == true)
        {
            if (lv4_headandchest.activeSelf == false)
                lv4_headandchest.SetActive(true);
            if (lv4_abs.activeSelf == false)
                lv4_abs.SetActive(true);
        }
        if (head_abs_lv >= 8 && gender == false)
        {
            if (lv4_headandchestw.activeSelf == false)
                lv4_headandchestw.SetActive(true);
            if (lv4_abs.activeSelf == false)
                lv4_abs.SetActive(true);
        }
        if (headandchest_lv == 1 && gender == true)
        {
            if (lv1_man.activeSelf == false)
                lv1_man.SetActive(true);
        }
        else if (headandchest_lv == 1 && gender == false)
        {
            if (lv1_woman.activeSelf == false)
                lv1_woman.SetActive(true);
        }
        if (headandchest_lv == -1)
        {
            if (misingno.activeSelf == false)
                misingno.SetActive(true);
        }
    }
    void Set_LowerBody()
    {
        if (lowerbody_lv != 1)
        {
            if (lowerbody_lv == 2 && gender == true)
            {
                if (lv2_lowerbody.activeSelf == false)
                    lv2_lowerbody.SetActive(true);
            }
            if (lowerbody_lv == 2 && gender == false)
            {
                if (lv2_lowerbodyw.activeSelf == false)
                    lv2_lowerbodyw.SetActive(true);
            }
            if (lowerbody_lv == 3 && gender == true)
            {
                if (lv3_lowerbody.activeSelf == false)
                    lv3_lowerbody.SetActive(true);
            }
            if (lowerbody_lv == 3 && gender == false)
            {
                if (lv3_lowerbodyw.activeSelf == false)
                    lv3_lowerbodyw.SetActive(true);
            }
            if (lowerbody_lv == 4 && gender == true)
            {
                if (lv4_lowerbody.activeSelf == false)
                    lv4_lowerbody.SetActive(true);
            }
            if (lowerbody_lv == 4 && gender == false)
            {
                if (lv4_lowerbodyw.activeSelf == false)
                    lv4_lowerbodyw.SetActive(true);
            }
        }
    }
    void Set_Back()
    {
        if (back_lv != 1)
        {
            if (back_lv == 2)
            {
                if (lv2_rightback.activeSelf == false)
                    lv2_rightback.SetActive(true);
                if (lv2_leftback.activeSelf == false)
                    lv2_leftback.SetActive(true);
            }
            if (back_lv == 3)
            {
                if (lv3_rightback.activeSelf == false)
                    lv3_rightback.SetActive(true);
                if (lv3_leftback.activeSelf == false)
                    lv3_leftback.SetActive(true);
            }

            if (back_lv == 4)
            {
                if (lv4_rightback.activeSelf == false)
                    lv4_rightback.SetActive(true);
                if (lv4_leftback.activeSelf == false)
                    lv4_leftback.SetActive(true);
            }
        }
    }
    void Set_ArmAndShoulder()
    {
        if (arm_shoulder_lv >= 4 && arm_shoulder_lv < 6)
        {
            if (lv2_rightarm.activeSelf == false)
                lv2_rightarm.SetActive(true);
            if (lv2_leftarm.activeSelf == false)
                lv2_leftarm.SetActive(true);
            if (lv2_shoulder.activeSelf == false)
                lv2_shoulder.SetActive(true);
        }
        if (arm_shoulder_lv >= 6 && arm_shoulder_lv < 8)
        {
            if (lv3_rightarm.activeSelf == false)
                lv3_rightarm.SetActive(true);
            if (lv3_leftarm.activeSelf == false)
                lv3_leftarm.SetActive(true);
            if (lv3_shoulder.activeSelf == false)
                lv3_shoulder.SetActive(true);
        }

        if (arm_shoulder_lv >= 8)
        {
            if (lv4_rightarm.activeSelf == false)
                lv4_rightarm.SetActive(true);
            if (lv4_leftarm.activeSelf == false)
                lv4_leftarm.SetActive(true);
            if (lv4_shoulder.activeSelf == false)
                lv4_shoulder.SetActive(true);
        }
    }
    void Cleaner_HeadAndChest()
    {
        if (lv2_headandchest.activeSelf == true)
        {
            lv2_headandchest.SetActive(false);
        }
        if (lv3_headandchest.activeSelf == true)
        {
            lv3_headandchest.SetActive(false);
        }
        if (lv4_headandchest.activeSelf == true)
        {

            lv4_headandchest.SetActive(false);
        }
        if (lv2_headandchestw.activeSelf == true)
        {
            lv2_headandchestw.SetActive(false);
        }
        if (lv3_headandchestw.activeSelf == true)
        {
            lv3_headandchestw.SetActive(false);
        }
        if (lv4_headandchestw.activeSelf == true)
        {
            lv4_headandchestw.SetActive(false);
        }
        if (lv1_man.activeSelf == true)
        {
            lv1_man.SetActive(false);
        }
        if (lv1_woman.activeSelf == true)
        {
            lv1_woman.SetActive(false);
        }
        if (misingno.activeSelf == true)
        {
            misingno.SetActive(false);
        }

    }
    void Cleaner_LowerBody()
    {

        if (lv2_lowerbody.activeSelf == true)
        {
            lv2_lowerbody.SetActive(false);
        }
        if (lv3_lowerbody.activeSelf == true)
        {
            lv3_lowerbody.SetActive(false);
        }
        if (lv4_lowerbody.activeSelf == true)
        {
            lv4_lowerbody.SetActive(false);
        }
        if (lv2_lowerbodyw.activeSelf == true)
        {
            lv2_lowerbodyw.SetActive(false);
        }
        if (lv3_lowerbodyw.activeSelf == true)
        {
            lv3_lowerbodyw.SetActive(false);
        }
        if (lv4_lowerbodyw.activeSelf == true)
        {
            lv4_lowerbodyw.SetActive(false);
        }
    }
    void Cleaner_RightBack()
    {
        if (lv2_rightback.activeSelf == true)
        {
            lv2_rightback.SetActive(false);
        }
        if (lv3_rightback.activeSelf == true)
        {
            lv3_rightback.SetActive(false);
        }
        if (lv4_rightback.activeSelf == true)
        {
            lv4_rightback.SetActive(false);
        }
    }
    void Cleaner_LeftBack()
    {
        if (lv2_leftback.activeSelf == true)
        {
            lv2_leftback.SetActive(false);
        }
        if (lv3_leftback.activeSelf == true)
        {
            lv3_leftback.SetActive(false);
        }
        if (lv4_leftback.activeSelf == true)
        {
            lv4_leftback.SetActive(false);
        }
    }
    void Cleaner_RightArm()
    {
        if (lv2_rightarm.activeSelf == true)
        {
            lv2_rightarm.SetActive(false);
        }
        if (lv3_rightarm.activeSelf == true)
        {
            lv3_rightarm.SetActive(false);
        }
        if (lv4_rightarm.activeSelf == true)
        {
            lv4_rightarm.SetActive(false);
        }
    }
    void Cleaner_LeftArm()
    {
        if (lv2_leftarm.activeSelf == true)
        {
            lv2_leftarm.SetActive(false);
        }
        if (lv3_leftarm.activeSelf == true)
        {
            lv3_leftarm.SetActive(false);
        }
        if (lv4_leftarm.activeSelf == true)
        {
            lv4_leftarm.SetActive(false);
        }
    }
    void Cleaner_Abs()
    {
        if (lv2_abs.activeSelf == true)
        {
            lv2_abs.SetActive(false);
        }
        if (lv3_abs.activeSelf == true)
        {
            lv3_abs.SetActive(false);
        }
        if (lv4_abs.activeSelf == true)
        {
            lv4_abs.SetActive(false);
        }
    }
    void Cleaner_Shoulder()
    {
        if (lv2_shoulder.activeSelf == true)
        {
            lv2_shoulder.SetActive(false);
        }
        if (lv3_shoulder.activeSelf == true)
        {
            lv3_shoulder.SetActive(false);
        }
        if (lv4_shoulder.activeSelf == true)
        {
            lv4_shoulder.SetActive(false);
        }
    }
    void Clean_All()
    {
        Cleaner_HeadAndChest();
        Cleaner_LowerBody();
        Cleaner_RightBack();
        Cleaner_LeftBack();
        Cleaner_RightArm();
        Cleaner_LeftArm();
        Cleaner_Abs();
        Cleaner_Shoulder();

    }
    void Set_All()
    {
        Set_HeadAndAbs();
        Set_LowerBody();
        Set_Back();
        Set_ArmAndShoulder();
        Set_Position_body();

    }
    void Checker()
    {
        if (headandchest_lv != 1 || abs_lv != 1 || lowerbody_lv != 1 || back_lv != 1 || arm_lv != 1 || shoulder_lv != 1) 
        {
            if (headandchest_lv == 1)
            {
                headandchest_lv = 2;
            }
            if (abs_lv == 1)
        {
            abs_lv = 2;
        }
        if (lowerbody_lv == 1)
        {
            lowerbody_lv = 2;
        }
        if (back_lv == 1)
        {
            back_lv++;
        }
        if (arm_lv == 1)
        {
            arm_lv++;
        }
        if (shoulder_lv == 1)
        {
            shoulder_lv++;
        }
    } 
    }

    void Headandchest_LevelChange(int Headandchest_level)
    {
        headandchest_lv = Headandchest_level;
    }
    void Back_LevelChange(int Back_level)
    {
        back_lv = Back_level;
    }
    void Arm_LevelChange(int Arm_level)
    {
        arm_lv = Arm_level;
    }
    void Lowerbody_LevelChange(int Lowerbody_level)
    {
         lowerbody_lv = Lowerbody_level;
    }
    void Abs_LevelChange(int Abs_level)
    {
        abs_lv = Abs_level;
    }
    void Shoulder_LevelChange(int Shoulder_level)
    {
        shoulder_lv = Shoulder_level;
    }
    void GenderChange(bool Gender)
    {
        gender = Gender;
    }

}