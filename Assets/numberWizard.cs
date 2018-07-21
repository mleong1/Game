using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numberWizard : MonoBehaviour {

    [SerializeField] int guessMax;
    [SerializeField] int guessMin;
    //need to link guess to the output text in Guess Text game object 
    [SerializeField] Text guessText;
    int guess;

    // Use this for initialization
    void Start () {
        //setup code only happens once
        StartGame();
	}

    void StartGame()
    {
        //guessMax and guessMin are in the serialized field in inspector
        guess = (guessMax + guessMin) / 2;
        //tostring to convert the int guess into a string for text
        guessText.text = guess.ToString();
        guessMax += 1;
    }

    public void onPressHigher()
    {
        guessMin = guess;
        NextGuess();
    }

    public void onPressLower()
    {
        guessMax = guess;
        NextGuess();
    }
	

    void NextGuess()
    {
        guess = (guessMax + guessMin) / 2;
        guessText.text = guess.ToString();
    }
}
