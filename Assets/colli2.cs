using UnityEngine;

public class Colli2 : MonoBehaviour
{
    // ���� 2D ���岢����ʵ����ײʱ������ô˷���
    void OnCollisionEnter2D(Collision2D collision)
    {
        // ���ﲻ����ײ������������жϣ������Ҫ������ͨ�� collision.gameObject.tag ������ǩ��
        // һ��������ײ�����ٵ�ǰ��ʯ����
        Destroy(gameObject);
    }
}
