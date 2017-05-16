using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    public static int score = 0;

    private void Update()
    {
        text.text = score.ToString();
    }

}
