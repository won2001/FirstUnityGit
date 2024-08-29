using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;

    private Coroutine delayJumpCoroutine;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (delayJumpCoroutine == null)
            {
                delayJumpCoroutine = StartCoroutine(DelayJump());
            }
           
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (delayJumpCoroutine != null)
            {
                StopCoroutine(delayJumpCoroutine);// 코루틴을 멈춰줘야함
                delayJumpCoroutine = null;
            }
        }
    }

    IEnumerator DelayJump()
    {
        Debug.Log(3);
        yield return new WaitForSeconds(1f);
        Debug.Log(2);
        yield return new WaitForSeconds(1f);
        Debug.Log(1);
        yield return new WaitForSeconds(1f);

        rigid.AddForce(Vector3.up * 10f, ForceMode.Impulse);

        delayJumpCoroutine = null;
    }

    // <코루틴 지연>
    // 코루틴은 반복작업 중 지연처리를 정의하여 작업의 진행 타이밍을 지정할 수 있음

    IEnumerator CoroutineWait()
    {
        yield return null;                      // 한 프레임 지연
        yield return new WaitForSeconds(1f);    // n초간 시간 지연
        yield return new WaitForSecondsRealtime(1f);    // 현실 n초간 시간 지연
        yield return new WaitForFixedUpdate();      // FixedUpdate 까지 지연
        yield return new WaitForEndOfFrame();       // 프레임의 끝까지 지연
        yield return new WaitUntil(() => true);     // 
    }
}
