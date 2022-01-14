using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;



public class ScoreCode : MonoBehaviour

{
  


    //だ计把计

    public static int Score;
    private static int currScore;
    private static int finalScore;
    //ゅUI

    public Text ShowScore;

    void Start()
    {
        
         Score = 0;
         
    }

    void Update()

    {

        //琵UIゅ籔だ计˙

        ShowScore.text = Score.ToString();

       

    }
    

    public int CurrScore
    {
            

        get
        {
            return currScore;
        }


    }

}