using UnityEngine;

public class randoms : MonoBehaviour
{
    public GameObject meteorPrefab; // ��ʯ��Ԥ����
    public float spawnRate = 2f;    // ÿ������������һ����ʯ
    public float spawnDistance = 10f; // ������ʯ�ľ��룬��Ļ��һ����Χ

    public float meteorSpeed = 5f; // ��ʯ���ٶ�

    private float timer = 0f; // �������ɼ���ļ�ʱ��

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnMeteor();
            timer = 0f; // ���ü�ʱ��
        }
    }

    void SpawnMeteor()
    {
        // ���ѡ��һ����Ļ���λ��
        Vector2 spawnPosition = GetRandomSpawnPosition();

        // ������ʯ
        GameObject meteor = Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);

        // ����ʯ����Ļ�����ƶ�
        Vector2 targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        Vector2 direction = (targetPosition - spawnPosition).normalized;

        // ������ʯ���ٶ�
        Rigidbody2D rb = meteor.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = direction * meteorSpeed;
        }
    }

    Vector2 GetRandomSpawnPosition()
    {
        // ������Ļ�Ŀ��߷�Χ
        Vector3 screenBottomLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector3 screenTopRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        float randomX, randomY;
        int side = Random.Range(0, 4); // ���ѡ�����ɵ���Ļ��

        switch (side)
        {
            case 0: // ���
                randomX = screenBottomLeft.x - spawnDistance;
                randomY = Random.Range(screenBottomLeft.y, screenTopRight.y);
                break;
            case 1: // �Ҳ�
                randomX = screenTopRight.x + spawnDistance;
                randomY = Random.Range(screenBottomLeft.y, screenTopRight.y);
                break;
            case 2: // �Ϸ�
                randomX = Random.Range(screenBottomLeft.x, screenTopRight.x);
                randomY = screenTopRight.y + spawnDistance;
                break;
            case 3: // �·�
                randomX = Random.Range(screenBottomLeft.x, screenTopRight.x);
                randomY = screenBottomLeft.y - spawnDistance;
                break;
            default:
                randomX = 0;
                randomY = 0;
                break;
        }

        return new Vector2(randomX, randomY);
    }
}

