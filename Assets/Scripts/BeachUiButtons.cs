using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Management;

public class BeachUiButtons : MonoBehaviour
{
    [SerializeField] PlayableDirector _timeLine;
    [SerializeField] Camera _vrCamera;
    [SerializeField] Camera _normalCamera;
    [SerializeField] GameObject _cartBoardStartUp;
    [SerializeField] GameObject _canvas;
    [SerializeField]private int OnVrMode=0;
  
  //  [SerializeField] VRToggle VRtoggle;

   public void ButtonClickEvent(string strVal)
    {
        if(strVal=="BackBtn")
        {
            SceneManager.LoadScene(1);
        }
        else if(strVal=="WalkBtn")
        {
            _timeLine.Play();
        }
        else if(strVal== "VRBtn")
        {
            
            if (OnVrMode == 1)
            {
                OnVRStart();
                OnVrMode = 0;
            }
            //else if(OnVrMode ==0)
            //{
            //    OnVrMode = 1;
            //    OnVRStop();
               
            //}
            
        }
      
    }
    private void OnVRStart()
    {
     
       // _vrCamera.gameObject.SetActive(true);
        
        XRGeneralSettings.Instance.Manager.InitializeLoader();
        _canvas?.SetActive(false);
        _cartBoardStartUp.SetActive(true);
        //_normalCamera.gameObject.SetActive(false);
    }
    private void OnVRStop()
    {
       // _vrCamera.gameObject.SetActive(false);
        
       // XRGeneralSettings.Instance.Manager.StartSubsystems();
        //_normalCamera.gameObject.SetActive(true);
    }
}
