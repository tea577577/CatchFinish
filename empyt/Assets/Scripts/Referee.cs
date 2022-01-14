using UnityEngine;

public class Referee : MonoBehaviour
{
    [Header("��ܸ��")]
    public DataDialogue dataDialogue;
    [Header("��ܨt��")]
    public DialogueSystem dialogueSystem;
    [Header("Ĳ�o��ܪ���H")]
    public string target = "�گ�";

    //Ĳ�o�}�l�ƥ�
    // 1.��Ӫ��󳣭n��Collider 2D
    // 2.��Ӫ���n���@�Ӧ� Rigibody 2D
    // 3.��Ӫ���n���@�Ӥ� Is Trigger 
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.name == target)
        {
            dialogueSystem.StartDialogue(dataDialogue.dialogues);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            dialogueSystem.StopDialogue();
        }

    }
}
