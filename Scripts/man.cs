//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//*//
//public class man : MonoBehaviour
//{
//    int lv;
//    double exp;
//    public GameObject A, B, C, D;


//    void Start()
//    {
//        lv = 0;
//        exp = 0;
//        A = GameObject.Find("man1");
//        B = GameObject.Find("man2");
//        C = GameObject.Find("man3");
//        D = GameObject.Find("man4");

//    }

//    void Update()
//    {
//        if (lv == 1)
//        {
//            Disappear_man2();
//            Disappear_man3();
//            Disappear_man4();
//        }
//        if (lv == 2)
//        {
//            Disappear_man1();
//            Disappear_man3();
//            Disappear_man4();
//        }
//        if (lv == 3)
//        {
//            Disappear_man1();
//            Disappear_man2();
//            Disappear_man4();
//        }
//        if (lv == 4)
//        {
//            Disappear_man1();
//            Disappear_man2();
//            Disappear_man3();
//        }
//        if ()// �������� 1��(�� ���� exp�� �Ѿ����)
//        {
//            grow_back();
//        }
//        if ()// �������� 2��(���� ���� exp�� �Ѿ����)
//        {
//            grow_chest();
//        }
//        if ()// �������� 3��(��� ���� exp�� �Ѿ����)
//        {
//            grow_shoulder();
//        }
//        if ()// �������� 4��(���� ���� exp�� �Ѿ����)
//        {
//            grow_abs();
//        }
//        if ()// �������� 5��(�� ���� exp�� �Ѿ����)
//        {
//            grow_arm();
//        }
//        if ()// �������� 6��(�ٸ� ���� exp�� �Ѿ����)
//        {
//            grow_leg();
//        }
//    }

//    void Disappear_man1()
//    {
//        Vector3 scale = Vector3.zero;
//        A.transform.localScale += scale;
//    }
//    void Disappear_man2()
//    {
//        Vector3 scale = Vector3.zero;
//        B.transform.localScale += scale;
//    }
//    void Disappear_man3()
//    {
//        Vector3 scale = Vector3.zero;
//        C.transform.localScale += scale;
//    }
//    void Disappear_man4()
//    {
//        Vector3 scale = Vector3.zero;
//        D.transform.localScale += scale;
//    }

//    void grow_back()
//    {
//        scale.x = 0.01 * exp;
//        scale.y = 0.01 * exp;
//    }
//    void grow_chest()
//    {
//        scale.x = 0.01 * exp;
//        scale.y = 0.01 * exp;
//    }
//    void grow_shoulder()
//    {
//        scale.x = 0.01 * exp;
//        scale.y = 0.01 * exp;
//    }

//    void grow_abs()
//    {
//        scale.x = 0.01 * exp;
//        scale.y = 0.01 * exp;
//    }
//    void grow_arm()
//    {
//        scale.x = 0.01 * exp;
//        scale.y = 0.01 * exp;
//        leftarm1.transform.LocalScale += scale;
//        leftarm2.transform.LocalScale += scale;
//        leftarm3.transform.LocalScale += scale;
//        rightarm1.transform.LocalScale += scale;
//        rightarm2.transform.LocalScale += scale;
//        rightarm3.transform.LocalScale += scale;
//    }

//    void grow_leg()
//    { 
//        scale.x = 0.01 * exp;
//        scale.y = 0.01 * exp;
//    }
//}
