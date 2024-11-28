using UnityEngine;

public class colli : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        // 如果与子弹发生碰撞，则销毁陨石和子弹
        if (collision.gameObject.CompareTag("bullet(Clone)"))
        {
            Destroy(gameObject);           // 销毁陨石
        }
    }
}

