using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSpeed : MonoBehaviour
{
    //default to 25
    public static float speed = 30;
    private Text inputFieldText;

    private void Start()
    {
        inputFieldText = GetComponentInChildren<Text>();
    }

    public void ValueChanged()
    {
        if (int.TryParse(inputFieldText.text, out int value))
        {
            speed = value;
        }
        else
        {
            speed = 30;
        }
    }
}
