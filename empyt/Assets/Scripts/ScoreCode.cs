using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;



public class ScoreCode : MonoBehaviour

{
  


    //�ŧi���ưѼ�

    public static int Score;
    private static int currScore;
    private static int finalScore;
    //�ŧi��rUI

    public Text ShowScore;

    void Start()
    {
        
         Score = 0;
         
    }

    void Update()

    {

        //��UI��r�P���ƦP�B

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