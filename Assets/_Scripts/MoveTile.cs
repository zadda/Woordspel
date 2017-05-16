using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTile : MonoBehaviour 
{

    public CheckFreePosition checkFree; // = gameObject.GetComponent<CheckFreePosition>();

    bool onTray = false;

    //Transform startPosition;
    Vector3 startPositie;

    [SerializeField]
    Transform letter;

    [SerializeField]
    string LetterBetekenisInAlfabet;

    //[SerializeField]

    LetterValues letterValue;
    
   
    // Use this for initialization
    void Start () 
	{
        //startPosition = gameObject.GetComponent<Transform>();
        
        checkFree = GameObject.FindObjectOfType<CheckFreePosition>();
        letterValue = FindObjectOfType<LetterValues>();
    }
	
	
    public void MoveLetter(int letterOrder)
    {
        //letter = LetterBetekenisInAlfabet;
        //string letterAlfabet = letterValue.letter;
        //letter = letterAlfabet;
        //letter = letterValue.letterOrder;
        //Debug.Log("Button Clicked");

        checkFree.CheckFree(letterOrder);
        

        //if (CheckFreePosition.letter0_Free)
        //{
        //    //letter.position = CheckFreePosition.positie0;
        //}

        //this.transform.position = new Vector3(0, 690, 0);

        //  letter.position = new Vector3(0,50,0);
    }

    public void AddLetter(string letterToAdd)
    {
        //letterToAdd = letterValue.letter;
        Woord.woord += letterToAdd;
    }

    public void AddScore(int scoreToAdd)
    {
        //letterToAdd = letterValue.letter;
        Score.score = Score.score + scoreToAdd;
    }

   

}
