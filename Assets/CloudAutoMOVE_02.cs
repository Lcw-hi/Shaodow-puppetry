using UnityEngine;

public class CloudAutoMove_02 : MonoBehaviour
{
    public float speed = 0.3f; // 这里控制云的速度

    void Update()
    {
        // 让云每帧都往左移动一点点
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // 如果云飞出了屏幕左边，就让它从右边重新出现（循环效果）
        if (transform.position.x < -8f)
        {
            transform.position = new Vector3(12f, transform.position.y, 0);
        }
    }
}