using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class BC : MonoBehaviour

{

    //要被生成的怪物物件
    public GameObject[] ballprefabs;
    public int ballIndex;
    public float posvalue;
    public float moveSpeed;

    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("檢查地板尺寸與位移")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    void Start()

    {

        //執行生成怪物程式碼(每0.5秒一次)
         Vector2 BC = transform.position;
         BC.x = BC.x + moveSpeed;
         transform.position = BC;
        InvokeRepeating("BallCreater", 0.5f, 1);
        posvalue = GetComponent<Transform>().position.x;
       
    }

    //void Update
    //{

    //}
    public void BallCreater()

    {

        int BallNum;

        //隨機決定要生成幾個球(1-3個隨機)

        BallNum = Random.Range(1, 4);

        //開始生成球

        for (int i = 0; i < BallNum; i++)

        {
           
            //生成球球

            ballIndex = Random.Range(0, ballprefabs.Length);
            
            Instantiate(ballprefabs[ballIndex], new Vector3(posvalue, Random.Range(-4,3), 0), 
                ballprefabs[ballIndex].transform.rotation);

            //this.transform.position += new Vector3(0.5f,0, 0);
            //this.transform.position.x += 0.5f;

        }  

       
    }
 
    private void OnDrawGizmos()
    {
        // 1.決定圖示顏色
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        // 2.決定繪製圖形
        // transform.position 此物件的世界座標
        Gizmos.DrawSphere(transform.position +
            transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }
 
}