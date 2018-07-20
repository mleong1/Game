using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this allows you to create a new asset called state from create menu with the field of 
//story text

    //ScriptableObject scripts seem to be like factories to help you create new assets of
    //type script with its fields.
[CreateAssetMenu(menuName = "State")]
public class state : ScriptableObject {

    //TextArea is an inspector setting
    //first number is the minimum size in inspector of field and the second is the
    //amount of lines before we start to scroll.
    [TextArea(14, 10)][SerializeField]string storyText;
    [SerializeField] state[] nextStates;

    //getter method fro story text
    public string getStoryText()
    {
        return storyText;
    }

    public state[] getNextStates()
    {
        return nextStates;
    }
}
