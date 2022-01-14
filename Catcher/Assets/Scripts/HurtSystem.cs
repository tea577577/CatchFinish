using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HurtSystem : MonoBehaviour
{
    [Header("動畫參數")]
    public string parameterDead = "觸發死亡";
   
    [Header("死亡事件")]
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
