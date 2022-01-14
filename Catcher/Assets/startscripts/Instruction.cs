using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    [Header("對話資料")]
    public DataDialogue dataDialogue;
    [Header("說明系統")]
    public DialogueSystem Read;
 
    public void Click()
    {
        Read.StartDialogue(dataDialogue.dialogues);
     
    }

       
}
