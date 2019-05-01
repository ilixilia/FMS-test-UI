﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInfo : MonoBehaviour {

    public string Name;
    // public string Sex;
    public string Age;
    public string Height;
    public string Weight;

    public Text nametxtBox;
    // public Text sextxtBox;
    public Text agetxtBox;
    public Text heighttxtBox;
    public Text weighttxtBox;

    public InputInfo Script;

    void Start()
    {
        Name = Script.userName;
        Age = Script.userAge;
        Height = Script.userHeight;
        Weight = Script.userWeight;
        //Script.userName = Name;
        //Script.userAge = Age;
        //Script.userHeight = Height;
        //Script.userWeight = Weight;

        nametxtBox.text = Name;
        // sextxtBox = Sex;
        agetxtBox.text = Age;
        heighttxtBox.text = Height;
        weighttxtBox.text = Weight;

        //display info in console
        Debug.Log(Name + Age + Height + Weight);
    }

}
