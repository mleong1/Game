using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
    //instance variable
    //serialized field means we can find text component variable in inspector
    [SerializeField] Text textComponent;
    //now we have an instance variable for a state specifically the starting one 
    [SerializeField] state startingState;
    

    //what state are we currently in?
    state theState;

    //serializing fields is nice to work with unity GUI but i think you could specify
    //what state you want to use as an instance variable via code.

	// Use this for initialization
	void Start () {
        //accessing text field in textComponent. Text component here is Story Text.
        theState = startingState;
        textComponent.text = theState.getStoryText();
	}
	
	// Update is called once per frame
	void Update () {
        ManageState();
	}

    private void ManageState()
    {
        //could have used state[] here, but var works because we have context from getNextStates
        var nextStates = theState.getNextStates();
        for (int i = 0; i < nextStates.Length; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                theState = nextStates[i];
            }
        }

        /*if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            theState = nextStates[0];
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            theState = nextStates[1];
        }*/
        //move this display story to common code. all paths must display story
        textComponent.text = theState.getStoryText();
    }
}
