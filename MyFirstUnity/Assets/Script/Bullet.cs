using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] float speed;

    private void Start()
    {
        //�����ؼ� �Ȼ��
        //Destroy(gameObject, 5f);

    }
    private void OnEnable()
    {
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }

    public void SetSpeed(float speed)
    {
        //rigid.velocity = speed;
        this.speed = speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("�÷��̾� ����");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("�ٸ� ��ü�� �浹");
            Destroy(gameObject);
        }
    }
}
