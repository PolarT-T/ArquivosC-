using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneZ : MonoBehaviour
{
    public void OpenScene(int index)
    {
   
        if(Input.GetKeyDown(KeyCode.Z))
        {
          SceneManager.LoadScene(index);  
        }
    //public void OpenScene(int index)
    //{
        //index = Convert.ToInt32(ReadLine());
        //if(Input.GetButton(KeyCode.Z))
        //{
            //SceneManager.LoadScene(index);
        //}
    //}
    }
    
    

}