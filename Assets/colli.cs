using UnityEngine;

public class colli : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        // ������ӵ�������ײ����������ʯ���ӵ�
        if (collision.gameObject.CompareTag("bullet(Clone)"))
        {
            Destroy(gameObject);           // ������ʯ
        }
    }
}

