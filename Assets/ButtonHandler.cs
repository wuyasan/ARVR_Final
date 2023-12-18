using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonHandler : MonoBehaviour
{
    public GameObject model;
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject BackBtn;
    public GameObject Text;
    public GameObject p;
    public GameObject otp;
    public static int b1 = 0;
    public static int b2 = 0;
    public static int b3 = 0;
    public void HandleBtn()
    {
        btn1.SetActive(false);
        btn2.SetActive(false);
        btn3.SetActive(false);
        BackBtn.SetActive(true);
        Text.SetActive(false);
        p.SetActive(true);
    }

    public void Pressed1()
    {
        b1 = 1;
    }
    public void Pressed2()
    {
        b2 = 1;
    }
    public void Pressed3()
    {
        b3 = 1;
    }
}
