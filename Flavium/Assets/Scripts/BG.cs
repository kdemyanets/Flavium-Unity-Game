using UnityEngine;

public class BG : MonoBehaviour
{
    public float StartX;
    public float EndX;
    public float speed;

    // Update

    void Update()
    {
        if(transform.position.x < EndX) 
        {
            transform.position = new Vector2(StartX, transform.position.y);
        }

        else 
        {
            
        }
    }
}
