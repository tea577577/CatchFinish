using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Read : MonoBehaviour
{
  
    
    [Header("�C������")]
    public GameObject goRead;
    [Header("��ܫ���")]
    public KeyCode End = KeyCode.Mouse0;
   
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
      {
        goRead.SetActive(false); 
      }
    }
 
}
   
   
   