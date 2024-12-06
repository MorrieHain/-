using UnityEngine;

public class Colli2 : MonoBehaviour
{
    // 当有 2D 刚体并产生实际碰撞时，会调用此方法
    void OnCollisionEnter2D(Collision2D collision)
    {
        // 这里不对碰撞对象进行特殊判断，如果需要，可以通过 collision.gameObject.tag 来检查标签。
        // 一旦发生碰撞，销毁当前陨石对象。
        Destroy(gameObject);
    }
}
