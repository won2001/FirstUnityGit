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
            instance.gameObject.SetActive(false);//비활성화 해서
            instance.transform.parent = transform;
            instance.returnPool = this; //반납할때 여기로 반납해
            pool.Add(instance);//보관
        }
    }

    public PooledObject GetPool(Vector3 position, Quaternion rotation)//pool에서 하나꺼내서 사용해라
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
        else //비어있는게 없을땐 만들어서 줘라
        {
            PooledObject instance = Instantiate(prefab, position, rotation);
            instance.returnPool = this;
            return instance;
        }
    }

    public void ReturnPool(PooledObject instance)//사용이 끝난애들 반납하기
    {
        instance.gameObject.SetActive(false);
        instance.transform.parent = transform;
        pool.Add(instance);
    }
}
