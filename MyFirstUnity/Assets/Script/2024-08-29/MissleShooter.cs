using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleShooter : MonoBehaviour
{
    [SerializeField] GameObject missilePrefab;
    [SerializeField] float repeatTime;

    private Coroutine missileSpawnRoutine;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            missileSpawnRoutine = StartCoroutine(MissileSpawnRoutine());
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine(missileSpawnRoutine);
        }
    }

    IEnumerator MissileSpawnRoutine()
    {
        WaitForSeconds delay = new WaitForSeconds(repeatTime); //����ȭ ���� ������ �̸� ����� ���� ����.(ĳ��)

        while (true)
        {
            Instantiate(missilePrefab, transform.position, transform.rotation);//�̻�����
            yield return delay;// �� �� ��ٷȴ� ����
        }
    }
}
