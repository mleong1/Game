using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberWizard : MonoBehaviour {

    int guessMax;
    int guessMin;
    int guess;

    // Use this for initialization
    void Start () {
        //setup code only happens once
        StartGame();
	}

    void StartGame()
    {
        guessMax = 1000;
        guessMin = 1;
        guess = 500;
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
            NextGuess();
            print(guessMin);
            print(guess);
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            guessMax = guess;
            NextGuess();
            print(guessMax);
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I am correct!");
            print("Lets play again!");
            StartGame();
        }
	}

    void NextGuess()
    {
        guess = (guessMax + guessMin) / 2;
        print("It is higher than or lower than " + guess);
    }
}
