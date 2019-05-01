using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputInfo : MonoBehaviour {

    //Age input field
    public InputField ageField;
    public string userAge;

    //Name input field
    public InputField userNameField;
    public string userName;

    //Height input field
    public InputField heightField;
    public string userHeight;

    //E-mail input field
    public InputField mailField;
    public string userMail;

    //Weight input field
    public InputField weightField;
    public string userWeight;

    public void OnInput()
    {
        //set user info to text in input fields
        userAge = ageField.text;
        userName = userNameField.text;
        userHeight = heightField.text;
        userMail = mailField.text;
        userWeight = weightField.text;

        //display info in console
        Debug.Log(userAge + userName + userHeight + userMail + userWeight);
    }

    /*
    public void PassThroughScene()
    {
        DontDestroyOnLoad(ageField);
        DontDestroyOnLoad(userNameField);
        DontDestroyOnLoad(heightField);
        DontDestroyOnLoad(mailField);
        DontDestroyOnLoad(weightField);
    }
    */

}
