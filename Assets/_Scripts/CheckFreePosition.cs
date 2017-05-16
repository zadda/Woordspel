using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFreePosition : MonoBehaviour 
{
    [Header("Bovenste letters")]
    [SerializeField]
    bool[] letterFree;// = { true, true, true };
    int i = 0;

    [SerializeField]
    Transform[] positie;

    

    [Header("Array met speelveld letters")]
    [SerializeField]

    Transform[] letters;

    public void CheckFree(int order)
    {
      
        while (i < letters.Length)
        {
            if (letterFree[i])
            {
                letters[order].position = positie[i].position;
                //Woord.woord += letter;
                i++;
                return;
            }
            else
            {
                i++;
            }
            //i++;
        }
    }

    public void ResetIndex()
    {
        i = 0;
    }
}
