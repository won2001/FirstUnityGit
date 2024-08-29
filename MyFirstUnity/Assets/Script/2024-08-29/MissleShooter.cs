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
        WaitForSeconds delay = new WaitForSeconds(repeatTime); //최적화 문제 때문에 미리 만들어 놓고 쓴다.(캐싱)

        while (true)
        {
            Instantiate(missilePrefab, transform.position, transform.rotation);//미사일을
            yield return delay;// 몇 초 기다렸다 해줘
        }
    }
}
