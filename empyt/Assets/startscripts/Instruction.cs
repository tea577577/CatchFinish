using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    [Header("��ܸ��")]
    public DataDialogue dataDialogue;
    [Header("�����t��")]
    public DialogueSystem Read;
 
    public void Click()
    {
        Read.StartDialogue(dataDialogue.dialogues);
     
    }

       
}
