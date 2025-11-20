using UnityEngine;

public class CityMover : MonoBehaviour
{
    public float speed = 5f;
    private bool isMoving = false;

    Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (!isMoving) return;

        // Mover la ciudad hacia -X (izquierda) simulando avance del bus
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
    }

    public void StartMoving()
    {
        isMoving = true;
    }

    public void StopAndReset()
    {
        isMoving = false;
        transform.position = initialPosition;
    }
}
