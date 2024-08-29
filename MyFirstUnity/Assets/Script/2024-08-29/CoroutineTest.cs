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
                StopCoroutine(delayJumpCoroutine);// �ڷ�ƾ�� ���������
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

    // <�ڷ�ƾ ����>
    // �ڷ�ƾ�� �ݺ��۾� �� ����ó���� �����Ͽ� �۾��� ���� Ÿ�̹��� ������ �� ����

    IEnumerator CoroutineWait()
    {
        yield return null;                      // �� ������ ����
        yield return new WaitForSeconds(1f);    // n�ʰ� �ð� ����
        yield return new WaitForSecondsRealtime(1f);    // ���� n�ʰ� �ð� ����
        yield return new WaitForFixedUpdate();      // FixedUpdate ���� ����
        yield return new WaitForEndOfFrame();       // �������� ������ ����
        yield return new WaitUntil(() => true);     // 
    }
}
