using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class BC : MonoBehaviour

{

    //�n�Q�ͦ����Ǫ�����
    public GameObject[] ballprefabs;
    public int ballIndex;
    public float posvalue;
    public float moveSpeed;

    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("�ˬd�a�O�ؤo�P�첾")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    void Start()

    {

        //����ͦ��Ǫ��{���X(�C0.5��@��)
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

        //�H���M�w�n�ͦ��X�Ӳy(1-3���H��)

        BallNum = Random.Range(1, 4);

        //�}�l�ͦ��y

        for (int i = 0; i < BallNum; i++)

        {
           
            //�ͦ��y�y

            ballIndex = Random.Range(0, ballprefabs.Length);
            
            Instantiate(ballprefabs[ballIndex], new Vector3(posvalue, Random.Range(-4,3), 0), 
                ballprefabs[ballIndex].transform.rotation);

            //this.transform.position += new Vector3(0.5f,0, 0);
            //this.transform.position.x += 0.5f;

        }  

       
    }
 
    private void OnDrawGizmos()
    {
        // 1.�M�w�ϥ��C��
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        // 2.�M�wø�s�ϧ�
        // transform.position �����󪺥@�ɮy��
        Gizmos.DrawSphere(transform.position +
            transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }
 
}