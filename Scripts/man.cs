using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class man : MonoBehaviour
{
    int lv;
    double exp;
    public GameObject A, B, C, D;


    void Start()
    {
        lv = 0;
        A = GameObject.Find("man1");
        B = GameObject.Find("man2");
        C = GameObject.Find("man3");
        D = GameObject.Find("man4");

    }

    void Update()
    {
        if (lv == 1)
        {
            Disappear_man2();
            Disappear_man3();
            Disappear_man4();
        }
        if (lv == 2)
        {
            Disappear_man1();
            Disappear_man3();
            Disappear_man4();
        }
        if (lv == 3)
        {
            Disappear_man1();
            Disappear_man2();
            Disappear_man4();
        }
        if (lv == 4)
        {
            Disappear_man1();
            Disappear_man2();
            Disappear_man3();
        }
    }

    void Disappear_man1()
    {
        Vector3 scale = Vector3.zero;
        A.transform.localScale += scale;
    }
    void Disappear_man2()
    {
        Vector3 scale = Vector3.zero;
        B.transform.localScale += scale;
    }
    void Disappear_man3()
    {
        Vector3 scale = Vector3.zero;
        C.transform.localScale += scale;
    }
    void Disappear_man4()
    {
        Vector3 scale = Vector3.zero;
        D.transform.localScale += scale;
    }
