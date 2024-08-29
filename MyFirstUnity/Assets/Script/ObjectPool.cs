using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.Port;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] List<PooledObject> pool = new List<PooledObject>();
    [SerializeField] PooledObject prefab;
    [SerializeField] int size;


    private void Awake()
    {
        for (int i = 0; i < size; i++)
        {
            PooledObject instance = Instantiate(prefab);
            instance.gameObject.SetActive(false);//��Ȱ��ȭ �ؼ�
            instance.transform.parent = transform;
            instance.returnPool = this; //�ݳ��Ҷ� ����� �ݳ���
            pool.Add(instance);//����
        }
    }

    public PooledObject GetPool(Vector3 position, Quaternion rotation)//pool���� �ϳ������� ����ض�
    {
        if (pool.Count > 0)
        {
            PooledObject instance = pool[pool.Count - 1];
            instance.transform.position = position;
            instance.transform.rotation = rotation;
            instance.transform.parent = null;
            instance.returnPool = this;
            instance.gameObject.SetActive(true);
            

            pool.RemoveAt(pool.Count - 1);

            return instance;
        }
        else //����ִ°� ������ ���� ���
        {
            PooledObject instance = Instantiate(prefab, position, rotation);
            instance.returnPool = this;
            return instance;
        }
    }

    public void ReturnPool(PooledObject instance)//����� �����ֵ� �ݳ��ϱ�
    {
        instance.gameObject.SetActive(false);
        instance.transform.parent = transform;
        pool.Add(instance);
    }
}
