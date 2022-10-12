using System.Globalization;
using UnityEngine;

[CreateAssetMenu]
public class Parameters : ScriptableObject
{
    private const float MinSpawnDelay = 0.01f;
    private const float MinMovementSpeed = 0.001f;
    private const float MinMovementDistance = 0.1f;

    [SerializeField] private Cube _cubePrefab;
    [Header("Default values")]
    [SerializeField, Min(MinSpawnDelay)] private float _spawnDelay;
    [SerializeField, Min(MinMovementSpeed)] private float _movementSpeed;
    [SerializeField, Min(MinMovementDistance)] private float _movementDistance;

    private float _currentSpawnDelay;
    private float _currentMovementSpeed;
    private float _currentMovementDistance;

    public Cube CubePrefab => _cubePrefab;
    public float SpawnDelay => _currentSpawnDelay;
    public float MovementSpeed => _currentMovementSpeed;
    public float MovementDistance => _currentMovementDistance;

    private void OnEnable()
    {
        _currentSpawnDelay = _spawnDelay;
        _currentMovementSpeed = _movementSpeed;
        _currentMovementDistance = _movementDistance;
    }

    public void OnSpawnDelayChanged(string text)
    {
        TrySetFloatValueFromString(ref _currentSpawnDelay, text, MinSpawnDelay);
    }

    public void OnMovementSpeedChanged(string text)
    {
        TrySetFloatValueFromString(ref _currentMovementSpeed, text, MinMovementSpeed);
    }

    public void OnMovementDistanceChanged(string text)
    {
        TrySetFloatValueFromString(ref _currentMovementDistance, text, MinMovementDistance);
    }

    private void TrySetFloatValueFromString(ref float value, string text, float minValue = 0)
    {
        if (float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out float newValue))
            if (newValue >= minValue)
                value = newValue;
    }
}
