using UnityEngine;

public class Dis2 : MonoBehaviour
{
    public float lifeTime = 5f; // �ӵ����ڵ��ʱ�䣨�룩

    void Start()
    {
        // ������ʱ���� 5 ����Զ������ӵ�
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // ��ӡ����ײ�������������
        Debug.Log("�ӵ���ײ���ˣ�" + collision.gameObject.name);

        // ��ײ�������ӵ�
        Destroy(gameObject);
    }
}

