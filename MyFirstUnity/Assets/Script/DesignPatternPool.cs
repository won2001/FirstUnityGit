using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignPatternPool : MonoBehaviour
{
    /****************************************************
 *              ������ ���� ObjectPool              *
 ****************************************************/

    /*
     * <������Ʈ Ǯ ����>
     * ���α׷� ������ ����ϰ� ��Ȱ���ϴ� �ν��Ͻ����� Ǯ�� ������ ��
     * �ν��Ͻ��� ����&���� ��� �뿩&�ݳ��� ����ϴ� ���
     * 
     * 
     * <����>
     * 1. �ν��Ͻ����� ������ Ǯ�� ����
     * 2. ���α׷��� ���۽� Ǯ�� �ν��Ͻ����� �����Ͽ� ����
     * 3. �ν��Ͻ� ������ �ʿ��� �� Ǯ���� �뿩�Ͽ� ���
     * 4. �ν��Ͻ� ������ �ʿ��� �� Ǯ�� �ݳ��Ͽ� ���� 
     * 
     * <����>
     * 1. ����ϰ� ����ϴ� �ν��Ͻ� ������ �ҿ�Ǵ� ������带 ����
     * 2. ����ϰ� ����ϴ� �ν��Ͻ� ������ �δ�Ǵ� ������ �ݷ����� ������ ����
     * 
     * <������>
     * 1. �̸� �����س��� �ν��Ͻ����� ������� �ʴ� ��쿡�� �޸𸮸� �����ϰ� ����
     * 2. ������Ʈ Ǯ�� �������� ���������� �پ��� ������ ���α׷��� �δ��� �Ǵ� ��찡 ����
     */
}
namespace DesignPattern
{
    public class ObjectPool
    {
        private Stack<PooledObject> objectPool;
        private int size = 100;

        public void CreatePool()
        {
            objectPool = new Stack<PooledObject>(size);
            for (int i = 0; i < size; i++)
            {
                objectPool.Push(new PooledObject());
            }
        }

        public PooledObject GetPool()
        {
            return objectPool.Pop();
        }

        public void ReturnPool(PooledObject pooled)
        {
            objectPool.Push(pooled);
        }
    }

    public class PooledObject
    {
        // ����&������ ����� Ŭ����
    }
}

