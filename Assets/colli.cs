using UnityEngine;

public class Colli : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(gameObject);  
        }
    }
}

