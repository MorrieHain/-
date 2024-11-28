using UnityEngine;

public class dis : MonoBehaviour
{
    public float lifeTime = 5f; // 子弹的存活时间

    void Start()
    {
        // 在一定时间后销毁子弹，防止子弹无限存在
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 检查碰撞的对象是否是敌人
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // 销毁敌人
            Destroy(collision.gameObject);
        }

        // 无论如何销毁子弹
        Destroy(gameObject);
    }
}
