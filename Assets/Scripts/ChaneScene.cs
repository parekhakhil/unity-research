using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChaneScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2")){
        int thisLevel = SceneManager.GetActiveScene().buildIndex;
        if(thisLevel < SceneManager.sceneCountInBuildSettings){
            SceneManager.LoadScene(thisLevel + 1); 
        }
        else{
        }
            Debug.Log("Scene Count: " + SceneManager.sceneCountInBuildSettings);
        }
    }

    public void NextScene(){
      int thisLevel = SceneManager.GetActiveScene().buildIndex;
        if(thisLevel < SceneManager.sceneCountInBuildSettings){
            SceneManager.LoadScene(thisLevel + 1); 
        }
        else{
        }
            Debug.Log("Scene Count: " + SceneManager.sceneCountInBuildSettings);
    } 
}
