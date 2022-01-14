using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class PlayerCtr : MonoBehaviour
{public float moveSpeed;


    #region ���:���}
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 1500)]
    public float jump = 300;
    [Header("�ˬd�a�O�ؤo�P�첾")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    [Header("���D����P�i���D�ϼh")]
    public KeyCode keyjump = KeyCode.Space;
    public LayerMask canJumpLayer;
    [Header("�ʵe�Ѽ� : �����P���D")]
    public string parameterWalk = "�}�l�C��";
    public string paramterJump = "���D�}��";
    [Header("�G�q��")]
    private int extraJumps;
    public int extraJumpsValue;
     [Header("��ܨt��")]
    public GameObject goDialogue;
    
    
    [Header("�ʵe�Ѽ�")]
    public string parameterDead = "Ĳ�o���`";
    [Header("���`�ƥ�")]
    private Animator ani;
    public UnityEvent onDead;


    public AudioClip playerHit;
    public AudioSource audioSource;
    public AudioClip Jump;

    int HeartNum = 3;
    public GameObject Heart01;
    public GameObject Heart02;
    public GameObject Heart03;



    //�i��q����1/4�j
    [Header("�̰���q")]
    public int maxHealth = 5;

    [Header("��e��q"), Range(0, 5)]      //�b�ˬd���������U���+�i�հ� 
    //private int currentHelth;           //�w�q��e��q(�����)     
    public int currentHealth;             //�w�q��e��q(��ܦb�ˬd��)


    #endregion

    #region  ���:�p�H
    //private Animator ani;
    /// <summary>
    /// ���餸�� Rigidbody 2D
    /// </summary>
    private Rigidbody2D rig;
   
    private BC bc;
    

    private void Start()
    {

    
       
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        extraJumps = extraJumpsValue;
       

        audioSource = GetComponent<AudioSource>();
        //�i��q����2/4�j
        currentHealth = maxHealth;
        print("�گ��e��q��:" + currentHealth);


        //audioSource = GetComponent<AudioSource>

    }

    private void Update()
    {
        CheckGround();
        Jamp();
        
        if(isGround == true)
        {
            extraJumps = extraJumpsValue;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps >0 )
        {
            rig.velocity = Vector2.up * jump;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0 && isGround == true)
        {
            rig.velocity = Vector2.up * jump;
        }


        if(goDialogue == false)
        {
            Move();
        }
    }

    public void Move()   
    {
         Vector2 PlayerCtr = transform.position;
         PlayerCtr.x = PlayerCtr.x + moveSpeed;
         transform.position = PlayerCtr;
    }


   




     

    private void FixedUpdate()
    {
        //�i��q����4 / 4�j
        if (currentHealth == 0) Dead();
        
    }

    //�i��q����3/4�j
    public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {
            //PlaySound(playerHit);
        }

        currentHealth = currentHealth + amount;
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        print("�گ� ��e��q :" + currentHealth);


    }


    //�N�p�H�����ܦb�ݩʪ��W
    [SerializeField]

    private bool talking;
    private bool isGround;
    #endregion


    private void OnDrawGizmos()
    {
        // 1.�M�w�ϥ��C��
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        // 2.�M�wø�s�ϧ�
        // transform.position �����󪺥@�ɮy��
        Gizmos.DrawSphere(transform.position +
            transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }



    private void CheckGround()
    {
        //�I����T = 2D ���z,�л\�ϼh(�����I,�b�|,�ϼh)
        Collider2D hit = Physics2D.OverlapCircle(transform.position +
            transform.TransformDirection(checkGroundOffset), checkGroundRadius, canJumpLayer);

        //print("�I�쪺����W��:" + hit.name);

        isGround = hit;

        ani.SetBool(paramterJump, !isGround);

    }
    private void Jamp()
    {
        //�p�G����b�a�O�W �åB ���U���w����
        if (isGround && Input.GetKeyDown(keyjump))
        {
            //����,�K�[���O(�G���V�q)
            rig.AddForce(new Vector2(0, jump));
            PlaySound(Jump);
        }

    }


    //�U���o�Ө禡�O���a�I�����L����ɷ|����

    private void OnTriggerEnter2D(Collider2D collision)

    {

        //�p�G�I��y�ɡA���@���R��

        if (collision.tag == "damge")

        {

            //�R���y

            Destroy(collision.gameObject);



            //�R�߼ƶq-1

            HeartNum = HeartNum - 1;



            //�ھڷR�߼ƶq�A��ܷR�߹Ϯ�

            if (HeartNum == 2) //�p�G�٦������R��

            {

                //���Ĥ@���R������

                Heart01.SetActive(false);

            }

            else if (HeartNum == 1) //�p�G�٦��@���R��

            {

                //���ĤG���R������

                Heart02.SetActive(false);

            }

            else if (HeartNum == 0) //�p�G�S���R��

            {

                //���ĤT���R������

                Heart03.SetActive(false);
                Dead();
            }

        }

    }
    public void PlaySound(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }

    public void Hurt(float damage)
    {
       // if ( <=)
    }

    private void Dead()
    {
        ani.SetTrigger(parameterDead);
        onDead.Invoke();

    }

}
