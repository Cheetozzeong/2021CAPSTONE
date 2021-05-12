using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class man3 : MonoBehaviour
{
    int exp1, exp2, exp3, exp4, exp5, exp6;
    public GameObject leftarm1, leftarm2, leftarm3;
    public GameObject rightarm1, rightarm2, rightarm3;
    public GameObject chest1, chest2, chest3, lowchest1, lowchest2;
    public GameObject back1, back2;
    public GameObject head;
    public GameObject rightleg1, rightleg2;
    public GameObject leftleg1, leftleg2;
    public GameObject stomach1, stomach2, stomach3, stomach4, stomach5;
    // Start is called before the first frame update
    void Start()
    {
        leftarm1 = GameObject.Find("leftarm1");
        leftarm2 = GameObject.Find("leftarm2");
        leftarm3 = GameObject.Find("leftarm3");
        rightarm1 = GameObject.Find("rightarm1");
        rightarm2 = GameObject.Find("rightarm2");
        rightarm3 = GameObject.Find("rightarm3");
        back1 = GameObject.Find("back1");
        back2 = GameObject.Find("back2");
        chest1 = GameObject.Find("chest1");
        chest2 = GameObject.Find("chest2");
        chest3 = GameObject.Find("chest3");
        lowchest1 = GameObject.Find("lowchest1");
        lowchest2 = GameObject.Find("lowchest2");
        head = GameObject.Find("head");
        rightleg1 = GameObject.Find("rightleg1");
        rightleg2 = GameObject.Find("rightleg2");
        leftleg1 = GameObject.Find("leftleg1");
        leftleg2 = GameObject.Find("leftleg2");
        stomach1 = GameObject.Find("stomach1");
        stomach2 = GameObject.Find("stomach2");
        stomach3 = GameObject.Find("stomach3");
        stomach4 = GameObject.Find("stomach4");
        stomach5 = GameObject.Find("stomach5");
    }

    // Update is called once per frame
    void Update()
    {
        if ()// �������� 1��(�� ���� exp�� �Ѿ����)
        {
            grow_back();
        }
        if ()// �������� 2��(���� ���� exp�� �Ѿ����)
        {
            grow_chest();
        }
        if ()// �������� 3��(��� ���� exp�� �Ѿ����)
        {
            grow_shoulder();
        }
        if ()// �������� 4��(���� ���� exp�� �Ѿ����)
        {
            grow_abs();
        }
        if ()// �������� 5��(�� ���� exp�� �Ѿ����)
        {
            grow_arm();
        }
        if ()// �������� 6��(�ٸ� ���� exp�� �Ѿ����)
        {
            grow_leg();
        }
    }
    void grow_back()
    {
        double expc1 = 0.01 * exp1;
        scale.x = expc1;
        scale.y = expc1;
        back1.transform.LocalScale += scale;
        back2.transform.LocalScale += scale;
    }
    void grow_chest()
    {
        double expc2 = 0.01 * exp2;
        scale.x = expc2;
        scale.y = expc2;
        chest1.transform.LocalScale += scale;
    }
    void grow_shoulder()
    {
        double expc3 = 0.01 * exp3;
        scale.x = expc3;
        scale.y = expc3;
    }

    void grow_abs()
    {
        double expc4 = 0.01 * exp4;
        scale.x = expc4;
        scale.y = expc4;
    }
    void grow_arm()
    {
        double expc5 = 0.01 * exp5;
        scale.x = expc5;
        scale.y = expc5;
        leftarm1.transform.LocalScale += scale;
        leftarm2.transform.LocalScale += scale;
        leftarm3.transform.LocalScale += scale;
        rightarm1.transform.LocalScale += scale;
        rightarm2.transform.LocalScale += scale;
        rightarm3.transform.LocalScale += scale;
    }

    void grow_leg()
    {
        double expc6 = 0.01 * exp6;
        scale.x = expc6;
        scale.y = expc6;
    }
}
}
