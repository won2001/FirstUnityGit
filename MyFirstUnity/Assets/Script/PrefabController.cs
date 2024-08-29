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
    //[SerializeField] Rigidbody target; //������Ʈ�� ����Ⱑ��

   
    private void Update()
    {
        //����
        if (Input.GetKeyDown(KeyCode.S))
        {
           //gameObjInstance = Instantiate(tankPrefab, transform.position, transform.rotation);
          rigidInstance = Instantiate(rigidPrefab, transform.position, transform.rotation);
            rigidInstance.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }

        //�ı�
        if (Input.GetKeyDown(KeyCode.D))
        {
            Destroy(target, 2f);//2�ʵڿ� ����
        }
    }
}
