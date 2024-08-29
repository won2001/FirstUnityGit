using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] ObjectPool bulletPool;
    [SerializeField] ObjectPool[] SwapBullet;
    
    //[SerializeField] Bullet bulletPrefab;
    [SerializeField] Transform muzzlePoint;

    

    private void Start()
    {
        bulletPool = SwapBullet[0];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("1��");
            Swap(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("2��");
            Swap(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("3��");
            Swap(2);
        }
    }

    public void Fire()
    {
        //�����ؼ� ���
        // Bullet bullet = Instantiate(bulletPrefab, muzzlePoint.position, muzzlePoint.rotation);
        //  bullet.SetSpeed(bulletSpeed * muzzlePoint.forward);

        Debug.Log("�߻�߻�");
        // �뿩�ؼ� ���
        PooledObject instance = bulletPool.GetPool(muzzlePoint.position, muzzlePoint.rotation);//�� �Ѿ��� ������ �ʴ��� �� �𸣰ڽ��ϴ�.
        Bullet bullet = instance.GetComponent<Bullet>();
        
    }
    private void Swap(int index)
    {
        bulletPool = SwapBullet[index];
    }
}
