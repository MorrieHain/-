using UnityEngine;

public class dis : MonoBehaviour
{
    public float lifeTime = 5f; // �ӵ��Ĵ��ʱ��

    void Start()
    {
        // ��һ��ʱ��������ӵ�����ֹ�ӵ����޴���
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �����ײ�Ķ����Ƿ��ǵ���
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // ���ٵ���
            Destroy(collision.gameObject);
        }

        // ������������ӵ�
        Destroy(gameObject);
    }
}
