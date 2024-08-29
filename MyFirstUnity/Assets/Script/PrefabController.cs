using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabController : MonoBehaviour
{
    //[SerializeField] GameObject tankPrefab;
    [SerializeField] Rigidbody rigidPrefab;

    //[SerializeField] GameObject gameObjInstance;
    [SerializeField] Rigidbody rigidInstance;

    [SerializeField] GameObject target;
    //[SerializeField] Rigidbody target; //컴포넌트만 지우기가능

   
    private void Update()
    {
        //생성
        if (Input.GetKeyDown(KeyCode.S))
        {
           //gameObjInstance = Instantiate(tankPrefab, transform.position, transform.rotation);
          rigidInstance = Instantiate(rigidPrefab, transform.position, transform.rotation);
            rigidInstance.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }

        //파괴
        if (Input.GetKeyDown(KeyCode.D))
        {
            Destroy(target, 2f);//2초뒤에 삭제
        }
    }
}
