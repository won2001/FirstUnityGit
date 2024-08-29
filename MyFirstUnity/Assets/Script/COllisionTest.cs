using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COllisionTest : MonoBehaviour
{
    // 충돌을 시작했을 떄
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("플레이어와 부딪힐때 총알은 데미지를 준다.");

    }

    // 충돌 중일 때
    private void OnCollisionStay(Collision collision)
    {
        
    }

    // 충돌이 끝났을 때
    private void OnCollisionExit(Collision collision)
    {
        
    }
}
