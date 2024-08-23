using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float moveSpeed;
    [SerializeField] Vector3 startPosition;

    [SerializeField] float rate;

   //private void Start()
   //{
   //    startPosition = transform.position;
   //}
    private void Update()
    {
        gameObject.name = "��ũ";
       
        
    }
    private void PositionMove() //�������� �̵��ϱ�
    {
        //1�� ���� x ��ŭ ���������
        //x* Time.delta
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
    }
    private void TranslateMove()//�������� �̵��ϱ� �̷������ε� ������ �̵� ����
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    private void MoveTowardsMove()  // �������� �̵��ϱ� (���� �ӵ���)Ÿ���� ��ġ�� �����Ҷ����� �̵�
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }
    private void LerpMove() //�������� �̵��ϱ� (ó���� �����ٰ� ���� ������)
    {
        transform.position = Vector3.Lerp(transform.position, target.position, rate * Time.deltaTime);
    }
}
