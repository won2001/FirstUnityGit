using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    /*********************************************************************
     * ����ȭ (Serialization)
     * 
     * ������ ���� �Ǵ� ���ӿ�����Ʈ ���¸� �����ϰ� �����ϴ� ���
     * �ν����� â���� ������Ʈ�� ����ȭ�� ������� ���� ������
     * �̸� �̿��Ͽ� �ҽ��ڵ��� ���� ���� ����Ƽ �����Ϳ��� ���� ���� ����
     **********************************************************************/

    // <������ ����ȭ>
    // ������Ʈ�� ������� ���� Ȯ���ϰų� ����
    // ������Ʈ�� ������� ������ �巡�� �� ��� ������� ����

    [Header("Value Type")]
    // C# Type
    public bool boolValue;
    public int intValue;
    public float floatValue;
    public string stringValue;

    // Unity Type
    public Vector3 vector3;
    public Vector2 vector2;
    public Vector3Int intVector3;
    public Vector2Int intVector2;
    public Color color;

    public Rect rect;
    public LayerMask layerMask;
    public AnimationCurve curve;
    public Gradient gradient;

    // ������
    public enum JobType { Warriror, Mage, Rogue }
    public JobType jobType;

    // �迭 ��� �ڷᱸ��
    public int[] array;
    public List<JobType> list;

    [Header("Reference Type")]
    public Rigidbody rigid;
    public Collider coll;


    // <��Ʈ����Ʈ>
    // Ŭ����, �Ӽ� �Ǵ� �Լ� ���� ����Ͽ� Ư���� ������ ��Ÿ�� �� �ִ� ��Ŀ

    //[Space(30)]
    //
    //[Header("Unity Attribute")]

    [SerializeField] int privateValue;
    [HideInInspector] public int publicValue;

    [Range(3, 5)]
    public float percent = 4;

    [TextArea(3, 5)]
    public string story;

    [System.Serializable]
    public struct Data
    {
        public string name;
        public int level;
        public float rate;
    }
    public Data data;

    [System.Serializable]
    public class ClassType
    {
        public string name;
        public int level;
        public float rate;
    }
    public ClassType refer;


    /*******************************************************************
     * ����Ƽ �޽��� �Լ�
     * 
     * ����Ƽ�� ������ �޽����� �����ϴ� �Լ�
     * MonoBehaviour Ŭ������ �޽����� ���� �̸��� �Լ��� ����
     * ��ũ��Ʈ�� ����Ƽ ������ ������ �޽����� �޾� ��� Ÿ�̹��� Ȯ��
     * �޽��� �Լ����� �ڽ��� �ൿ�� �����Ͽ� ����� ����
     *******************************************************************/

    private void Awake()
    {
        // ��ũ��Ʈ�� ���� ���ԵǾ��� �� 1ȸ ȣ��
        // ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ� �ִ� ��쿡�� ȣ���

        // ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� �ʱ�ȭ �۾� ����
        //        (�ܺ� ���ӻ�Ȳ�� ������ �ʱ�ȭ �۾�)

        Debug.Log("Awake");
    }

    private void Start()
    {
        // ��ũ��Ʈ�� ���� ó������ Update�ϱ� ������ 1ȸ ȣ��
        // ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ� �ִ� ��� ȣ����� ����

        // ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� �ʱ�ȭ �۾� ����
        //        (�ܺ� ���ӻ�Ȳ�� �ʿ��� �ʱ�ȭ �۾�)

        Debug.Log("Start");
    }

    private void OnEnable()
    {
        // ��ũ��Ʈ�� Ȱ��ȭ�� ������ ȣ��

        // ���� : ��ũ��Ʈ�� Ȱ��ȭ �Ǿ��� �� �۾� ����

        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        // ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ȣ��

        // ���� : ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ��� �� �۾� ����

        Debug.Log("OnDisable");
    }

    private void Update()
    {
        // ������ ������ ȣ��

        // ���� : �ٽ� ���� ���� ����

        Debug.Log("Update");
    }

    private void OnDestroy()
    {
        // ��ũ��Ʈ�� ������ �����Ǿ��� �� 1ȸ ȣ��

        // ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� ������ �۾� ����

        Debug.Log("OnDestroy");
    }
}
