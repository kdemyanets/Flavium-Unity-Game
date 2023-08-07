using UnityEngine.Events;
using UnityEngine;

public class Eventer : MonoBehaviour

{
    public UnityEvent onMouseClicked;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onMouseClicked?.Invoke();
        }
    }
}