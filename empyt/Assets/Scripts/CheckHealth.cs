using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �˴��I����Ruby�[��(�ƭ�1)���ˬd�O�_���a���ⱵĲ���ˬd���a����O�_���媬�A
/// </summary>
public class HealthCollectableV5 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerCtr PC = collision.GetComponent<PlayerCtr>();

        //�ˬd��Ĳ����YRubyMove2����u�ëD���šv�]��ܱ�Ĳ���ORuby�����^
        //if (PC != null)
        //{
            //if (PlayerCtr.health < PlayerCtr.maxHealth) �w�q���d�P�����d************
            //{
                //print("�I���e Ruby ����q���G" + PlayerCtr.health);�w�q���d*************
                //print("�I��F�I�I�쪺�F��O�G" + PC);
                //PlayerCtr.ChangeHealth(1); �w�q�ﰷ�d************
                //Destroy(gameObject);
            //}
            //else
            //{
                //print("�{�bRuby�O���媬�A");
            //}
        //}
        //else
        {
            print("�ڬO�ĤH");
        }

        //transform.position = Vector2.zero;
        //�W�������եΡA�Y�W�z���� null ����h���檺�{���X�A��ѼĤH�I���ɡ]����|�^��(0,0)����m�W�^
    }


}
