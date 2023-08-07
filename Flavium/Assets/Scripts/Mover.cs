using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
