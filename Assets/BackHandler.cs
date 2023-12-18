using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackHandler : MonoBehaviour
{
    public GameObject model;
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject BackBtn;
    public GameObject Text;
    public GameObject p;
    public GameObject otp;
    public static int pressed = 0;
    public void HandleBtn()
    {
        btn1.SetActive(true);
        btn2.SetActive(true);
        btn3.SetActive(true);
        BackBtn.SetActive(false);
        Text.SetActive(true);
        p.SetActive(false);
    }

    public void Pressed()
    {
        pressed = 1;
    }
}
