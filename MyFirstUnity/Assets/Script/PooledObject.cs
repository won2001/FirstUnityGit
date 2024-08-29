using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObject : MonoBehaviour
{
    //�ݳ��ϴ� ���
    public ObjectPool returnPool;
    [SerializeField] float returnTime = 10;
   

    private float curTime;

    private void OnEnable()
    {
        curTime = returnTime;
    }

    private void Update()
    {
        curTime -= Time.deltaTime;
        if (curTime < 0)
        {
            returnPool.ReturnPool(this);
        }
    }

}
