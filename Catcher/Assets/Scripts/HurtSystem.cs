using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HurtSystem : MonoBehaviour
{
    [Header("�ʵe�Ѽ�")]
    public string parameterDead = "Ĳ�o���`";
   
    [Header("���`�ƥ�")]
    public UnityEvent onDead;
    private Animator ani;

    public void Hurt(float damage)
    {
        ani.GetComponent<Animator>();
    }

    private void Dead()
    {
        ani.SetTrigger(parameterDead);
        onDead.Invoke();
    }

}
