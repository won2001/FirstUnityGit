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
        gameObject.name = "탱크";
       
        
    }
    private void PositionMove() //방향으로 이동하기
    {
        //1초 동안 x 만큼 가고싶으면
        //x* Time.delta
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
    }
    private void TranslateMove()//방향으로 이동하기 이런식으로도 앞으로 이동 가능
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    private void MoveTowardsMove()  // 목적지로 이동하기 (일정 속도로)타겟의 위치로 도착할때까지 이동
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }
    private void LerpMove() //목적지로 이동하기 (처음에 빨랐다가 점점 느려짐)
    {
        transform.position = Vector3.Lerp(transform.position, target.position, rate * Time.deltaTime);
    }
}
