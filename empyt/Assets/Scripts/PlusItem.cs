   using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �i�����_���ϡi���ͯS�ġj�ϡi���ͭ��ġj
/// </summary>
public class PlusItem : MonoBehaviour
{
    public AudioClip hitSound;
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    public AudioClip audioClip;

    void Update()

    {


        //�Ǫ�����V�U����

        this.transform.position += new Vector3(-0.05f,0, 0);

        //if (PlayerCtr)
        //source.PlayOneShot()
    }

    //�p�G�Q�F��I��

    private void OnTriggerEnter2D(Collider2D collision)

    {

        //Instantiate(pickE, gameObject.transform.position, Quaternion.identity);

        

        PlayerCtr pc = collision.GetComponent<PlayerCtr>();
        print("�I�쪺�F��O:" + pc);
        pc.ChangeHealth(-1);
        Destroy(gameObject);


        pc.PlaySound(audioClip);

        //�p�G�Q���a����

        if (collision.name == "�گ�")

        {
       

            //����Ǫ����`

            BallDie();

        }

        

if (collision.name == "Wall_4")

        {

            //�Ǫ�����

            Destroy(this.gameObject);

        }

    }


    //�z���������Ǫ�����

    public void BallDie()

    {

        //�Ǫ�����

        Destroy(this.gameObject);

    }

    


}