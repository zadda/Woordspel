using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterValues : MonoBehaviour 
{



    Vector3 startPositie;


    //[SerializeField]
    //Transform positie;
    [SerializeField]
    public string letter;
    [SerializeField]
    int wordValue = 3;
    [SerializeField]
    public int letterOrder = 0;
    // Use this for initialization
    void Start () 
	{
        //startPositie = GetComponent<Position>().transform.position;
        //get tiles start position
        
       // Debug.Log(startPositie);
    }

    public void SetStartPositionAfterGizmo()
    {
        startPositie = transform.position;
    }


    public void ResetToStartPosition()
    {
        
        //transform.position = startPosition.position;
        //transform.position = startPosition.position;
        //transform.position = startPosition.position; OK??
        transform.position = startPositie;// new Vector3(startPosition.position.x, startPosition.position.y, startPosition.position.z);

    }
}