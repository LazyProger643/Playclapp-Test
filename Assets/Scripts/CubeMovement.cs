using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private Parameters _parameters;

    private Vector3 _targetPosition;
    private float _movementSpeed;

    private void Awake()
    {
        _targetPosition = GetRandomTargetPosition();
        _movementSpeed = _parameters.MovementSpeed;
    }

    private void Update()
    {
        if (transform.position == _targetPosition)
            Destroy(gameObject);
        else
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _movementSpeed * Time.deltaTime);
    }

    private Vector3 GetRandomTargetPosition()
    {
        return transform.position + UnityEngine.Random.insideUnitSphere.normalized * _parameters.MovementDistance;
    }
}
