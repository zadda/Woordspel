using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CheckWoordInArray : MonoBehaviour 
{
    public TextAsset dataFile;
    public Text woordCorrectOfNiet;

    public Text logging;
    public Text woordenCorrect;


    public LetterValues[] letterValues;

    CheckFreePosition checkFreePos;


    //public MoveTile[] moveTile;

    // Use this for initialization
    string[] textArray;

    public int textIndex;// = 0;

    void Start()
    {
        textIndex = 0;
        letterValues = FindObjectsOfType<LetterValues>();
        checkFreePos = FindObjectOfType<CheckFreePosition>();
        //moveTile = FindObjectsOfType<MoveTile>();

        //var textArray = dataFile.text.Split('\n');
        textArray = dataFile.text.Split('\n');

        CleanTextArray();
        Debug.Log(textArray[0]);
    }

    private void CleanTextArray()
    {
        do
        {
            textArray[textIndex] = textArray[textIndex].Remove(textArray[textIndex].Length - 1); // verwijder de return op het einde van het woord 
            textIndex++;
        }
        while (textIndex < textArray.Length);// && (textArray[textIndex].Contains("@") == true));  //(Environment.NewLine));
        textIndex = 0;
    }

    public void CheckWoordCorrect()
        
    {
        
            ControleerArray();
      
    }
    

    private void ControleerArray()
    {
     
        do
        {
            if (Woord.woord.ToLower() == textArray[textIndex])
            {
                woordCorrectOfNiet.text = "Correct woord";

                woordenCorrect.text += Woord.woord.ToString() + "\n";

                Woord.woord = "";
                //                textIndex++;
                textIndex = 0;
                return;
            }
            else
            {
                woordCorrectOfNiet.text = "niet juist";
                logging.text = textArray[textIndex].ToString();

                textIndex++;
                

            }
            ResetLetters();


        } while (textIndex < textArray.Length);// && (textArray[textIndex].Contains("@") == true));  //(Environment.NewLine));
        Woord.woord = "";
        textIndex = 0;
    }

    void ResetLetters()
    {
       // Woord.woord = "";
        for (int i = 0; i < letterValues.Length; i++)
        {
            letterValues[i].ResetToStartPosition();
        }
        
        // textIndex = 1;
        checkFreePos.ResetIndex();
       
    }

}
