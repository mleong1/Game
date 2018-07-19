using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberWizard : MonoBehaviour {

    int guessMax = 1000;
    int guessMin = 1;
    int guess = 500;

    // Use this for initialization
    void Start () {
        //setup code only happens once
        StartGame();
	}

    void StartGame()
    {
        Debug.Log("Welcome to Number Wizard");
        print("Please pick a number");
        print("The highest number is " + guessMax);
        print("The lowest number is " + guessMin);
        print("Is number higher or lower than my 500");
        print("Push up = higher, push down = lower, push enter = correct");
        guessMax += 1;
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            guessMin = guess;
            guess = (guessMax + guessMin) / 2;
            print("Up arrow pressed");
            print(guessMin);
            print(guess);
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            guessMax = guess;
            guess = (guessMax + guessMin) / 2;
            print("Down arrow pressed");
            print(guessMax);
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Enter button pressed");
        }
	}
}
