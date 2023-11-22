using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0.02f;
    [SerializeField]
    private Vector3 moveDirection = Vector3.zero;

    public float MoveSpeed =>moveSpeed;

    // Update is called once per frame
    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    public void MoveTo(Vector3 direction)
    {
        moveDirection = direction;
    }
}
