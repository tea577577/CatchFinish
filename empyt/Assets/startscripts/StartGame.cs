using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    //public AudioClip STart;
    public AudioSource source;
    public void Click()
    {

        SceneManager.LoadScene("¹CÀ¸µe­±");
        //PlaySound(STart);
    }
    void Start()
    {
        source = GetComponent<AudioSource>();  //
    }
    private void Update()
    {
        //if ()
    }


}
