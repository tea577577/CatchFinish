using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour

    
{
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;

    void Update()

    {


        //�y����V������

        this.transform.position += new Vector3(-0.05f,0, 0);

        //if()
        {
        //Destroy(this.gameObject);
        }
    }

    //�p�G�Q�F��I��

    private void OnTriggerEnter2D(Collider2D collision)

    {


        //�p�G�Q���a����

        if (collision.name == "Tsau")

        {
            ScoreCode.Score = ScoreCode.Score + 10;

            //����y����

            Destroy(this.gameObject);

        }



    }
 
}

