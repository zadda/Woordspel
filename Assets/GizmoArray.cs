using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoArray : MonoBehaviour 
{
    [SerializeField]
    LetterValues[] teVerdelenLetters;
    [SerializeField]
    Position[] freeGizmoPositions;

    public static int gizmoIndex = 0;

    private LetterValues tempGO;
    //TESTING


    // Use this for initialization
    void Start () 
	{
        Shuffle();

        do
        {
           // freeGizmoPositions[gizmoIndex].transform.position = teVerdelenLetters[gizmoIndex].transform.position;
            teVerdelenLetters[gizmoIndex].transform.position = freeGizmoPositions[gizmoIndex].transform.position;

            teVerdelenLetters[gizmoIndex].SetStartPositionAfterGizmo();
            //SetStartPositionAfterGizmo();

            gizmoIndex++;
        }
        while (gizmoIndex < freeGizmoPositions.Length);// && (textArray[textIndex].Contains("@") == true));  //(Environment.NewLine));
        gizmoIndex = 0;
    }

    public void Shuffle()
    {
        for (int i = 0; i < teVerdelenLetters.Length; i++)
        {
            int rnd = Random.Range(0, teVerdelenLetters.Length);
            tempGO = teVerdelenLetters[rnd];
            teVerdelenLetters[rnd] = teVerdelenLetters[i];
            teVerdelenLetters[i] = tempGO;
        }
    }
}