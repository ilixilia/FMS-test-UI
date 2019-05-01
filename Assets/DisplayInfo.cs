using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInfo : MonoBehaviour {

    public string Name;
    public string Sex;
    public string Age;
    public string Height;
    public string Weight;

    public Text nametxtBox;
    public Text sextxtBox;
    public Text agetxtBox;
    public Text heighttxtBox;
    public Text weighttxtBox;

    public InputInfo Script;

    public void OnPress()
    {
        nametxtBox.text = Name;
        sextxtBox.text = Sex;
        agetxtBox.text = Age;
        heighttxtBox.text = Height;
        weighttxtBox.text = Weight;

        Script.userName = Name;
        Script.userAge = Age;
        Script.userHeight = Height;
        Script.userWeight = Weight;

    }

}
