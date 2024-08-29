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
            Debug.Log("1번");
            Swap(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("2번");
            Swap(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("3번");
            Swap(2);
        }
    }

    public void Fire()
    {
        //생성해서 사용
        // Bullet bullet = Instantiate(bulletPrefab, muzzlePoint.position, muzzlePoint.rotation);
        //  bullet.SetSpeed(bulletSpeed * muzzlePoint.forward);

        Debug.Log("발사발사");
        // 대여해서 사용
        PooledObject instance = bulletPool.GetPool(muzzlePoint.position, muzzlePoint.rotation);//왜 총알이 나가지 않는지 잘 모르겠습니다.
        Bullet bullet = instance.GetComponent<Bullet>();
        
    }
    private void Swap(int index)
    {
        bulletPool = SwapBullet[index];
    }
}
