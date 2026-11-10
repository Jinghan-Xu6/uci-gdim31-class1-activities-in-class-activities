using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    public Transform catTarget;
    public float chaseSpeed;

    private bool isChasing;

    public void StartChase()
    {
        isChasing = true;
    }

    public void StopChase()
    {
        isChasing = false;
    }

    void Update()
    {
        if (!isChasing)
            return;

        Vector2 batPos = transform.position;
        Vector2 CatPos = catTarget.position;
        Vector2 dir = (CatPos - batPos).normalized;
        transform.Translate(dir * chaseSpeed * Time.deltaTime);

    }
}
