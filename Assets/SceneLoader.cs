using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//now we can use namespace of scene management
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    //no start or update here

    //we need to access current scene index
    public void loadNextScene()
    {
        //int variable contains the current active scene's build index 
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        print(currentSceneIndex);
        //load the next scene
        // + 1 as opposed to ++ because ++ is an assignment whereas curr + 1 is the value + 1
      
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void loadStartScene()
    {
        SceneManager.LoadScene(0);
    }
	
}
