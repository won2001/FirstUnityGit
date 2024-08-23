using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceController : MonoBehaviour
{
    //[SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;

    private void Update()
    {
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
        //Self면 나를기준으로 앞으로 이동 World면 세상을 기준으로 이동
        //Rotate도 마찬가지로 Self면 나를기준으로 회전 World면 세상을 기준으로 회전
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
    }

}
