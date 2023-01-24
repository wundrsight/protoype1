using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitchManager : MonoBehaviour
{
  
    void Start()
    {
        
    }
    public void OnButtonClicke(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }
  
 
}
