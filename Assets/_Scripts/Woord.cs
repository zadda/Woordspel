using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Woord : MonoBehaviour 
{
    public Text text;
    public static string woord ="";

    private void Update()
    {
        text.text = woord.ToString();
    }

}
