using UnityEngine;

public class Dis2 : MonoBehaviour
{
    public float lifeTime = 5f; // 子弹存在的最长时间（秒）

    void Start()
    {
        // 在启动时设置 5 秒后自动销毁子弹
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 打印出碰撞到的物体的名称
        Debug.Log("子弹碰撞到了：" + collision.gameObject.name);

        // 碰撞后销毁子弹
        Destroy(gameObject);
    }
}

