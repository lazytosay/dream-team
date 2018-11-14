﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeCounter : MonoBehaviour {

    public float TimeElapsed = 0f;
    public string TimeString;

    public Text timeCounter_Text;

	void Start () {
        timeCounter_Text = GetComponent<Text>();
	}

    private void FixedUpdate()
    {
        TimeElapsed = TimeElapsed + Time.deltaTime;

        float timeTemp = TimeElapsed;
        int TimeH = (int)timeTemp / 3600;
        timeTemp = timeTemp - TimeH * 3600;
        int TimeM = (int)timeTemp / 60;
        timeTemp = timeTemp - TimeM - TimeM * 60;
        int TimeS = (int)timeTemp;

        TimeString = TimeH.ToString() + "H : " + TimeM.ToString() + "M : " + TimeS.ToString() + "S";

        timeCounter_Text.text = TimeString;
    }

}
