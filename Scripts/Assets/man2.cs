using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class man2 : MonoBehaviour
{
    public GameObject leftarm1, leftarm2, leftarm3;
    public GameObject rightarm1, rightarm2, rightarm3;
    public GameObject chest1, chest2, chest3;
    public GameObject back1, back2;
    public GameObject head;
    public GameObject rightleg1, rightleg2;
    public GameObject leftleg1, leftleg2;
    public GameObject stomach1, stomach2, stomach3, stomach4, stomach5;

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
        if (Input.GetMouseButtonDown(0))
        {
            SizeUp();
        }
    }
    void SizeUp()
    {
        Vector3 scale = Vector3.zero;
        scale.x = 1;
        scale.y = 1;
        head.transform.localScale += scale;
    }
}
