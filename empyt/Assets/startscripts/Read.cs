using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Read : MonoBehaviour
{
  
    
    [Header("遊戲說明")]
    public GameObject goRead;
    [Header("對話按鍵")]
    public KeyCode End = KeyCode.Mouse0;
   
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
      {
        goRead.SetActive(false); 
      }
    }
 
}
   
   
   