using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�إ߱M�פ������(menuName = "���W��") ��Ƨ�/�l���
[CreateAssetMenu( menuName = "Exit/��ܸ��")]
/// <summary>
/// ��ܸ��
/// �O�sNPC�򪱮a����ܸ��
/// </summary>
/// Scriptable Object �}���ƪ���:�N�{����Ƥ��x�s�� Project �������� 
public class DataDialogue : ScriptableObject
{
    //TextAres (�̤p���, �̤j���) - �ȭ� string
    [Header("��ܤ��e"), TextArea(3, 5)]
    public string[] dialogues;
}