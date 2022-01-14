using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class DialogueSystem : MonoBehaviour

{
    [Header("��ܶ��j"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("��ܨt��")]
    public GameObject goDialogue;
    [Header("��ܤ��e")]
    public  Text textContent;
    [Header("�T����")]
    public GameObject goTip;
    [Header("��ܫ���")]
    public KeyCode keyDialogue = KeyCode.Mouse0;
    public GameObject ballcreater;

    private void Start()
    {
       
    }
    private IEnumerator TypeEffect(string[] contents)
    {
        

        goDialogue.SetActive(true);       //��ܹ�ܪ���

        for (int j = 0; j < contents.Length; j++)
        {
            textContent.text = "";            //�M���W����ܤ��e 
            goTip.SetActive(false);
            
            for (int i = 0; i < contents[j].Length; i++)
            {
                textContent.text += contents[j][i];  //�|�[��ܤ��e����r
                yield return new WaitForSeconds(interval);
            }

            goTip.SetActive(true);

            while(!Input.GetKeyDown(keyDialogue))
            {
                yield return null; 
            }
        }

        goDialogue.SetActive(false);
        ballcreater.SetActive(true);
    }


    /// <summary>
    /// �}�l���
    /// </summary>
    /// <param name="contents">�n��ܥ��r�ĪG����ܤ��e</param>
    public void StartDialogue(string[] contents) 
    {
        StartCoroutine(TypeEffect(contents));
    }


    /// <summary>
    ///������ 
    /// </summary>
    public void StopDialogue()
    {
        StopAllCoroutines();             //�����{
        goDialogue.SetActive(false);     //���ù�ܤ���       
    }
}
