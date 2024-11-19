using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            rb2d.AddForce(Vector2.up * 300);
        }
        this.transform.eulerAngles = new Vector3(0, 0, 2.5f * rb2d.linearVelocityY);

    }
}
/* Д.З. Композиція сцени:
 * - підібрати картинки для фонового оточення (дерева, квіти, хмари тощо)
 * - встановити межі ігрового поля (сцени), реалізувати різні фізичні 
 *    параметри для різних меж (стін, стелі, підлоги)
 */