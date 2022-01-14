using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class DialogueSystem : MonoBehaviour

{
    [Header("對話間隔"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("對話系統")]
    public GameObject goDialogue;
    [Header("對話內容")]
    public  Text textContent;
    [Header("三角形")]
    public GameObject goTip;
    [Header("對話按鍵")]
    public KeyCode keyDialogue = KeyCode.Mouse0;
    public GameObject ballcreater;

    private void Start()
    {
       
    }
    private IEnumerator TypeEffect(string[] contents)
    {
        

        goDialogue.SetActive(true);       //顯示對話物件

        for (int j = 0; j < contents.Length; j++)
        {
            textContent.text = "";            //清除上次對話內容 
            goTip.SetActive(false);
            
            for (int i = 0; i < contents[j].Length; i++)
            {
                textContent.text += contents[j][i];  //疊加對話內容的文字
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
    /// 開始對話
    /// </summary>
    /// <param name="contents">要顯示打字效果的對話內容</param>
    public void StartDialogue(string[] contents) 
    {
        StartCoroutine(TypeEffect(contents));
    }


    /// <summary>
    ///停止對話 
    /// </summary>
    public void StopDialogue()
    {
        StopAllCoroutines();             //停止協程
        goDialogue.SetActive(false);     //隱藏對話介面       
    }
}
