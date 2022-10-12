using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private Parameters _parameters;

    private float _lastSpawnTime;

    private void Start()
    {
        _lastSpawnTime = Time.time;
    }

    private void Update()
    {
        float time = Time.time;

        if (time - _lastSpawnTime >= _parameters.SpawnDelay)
        {
            _lastSpawnTime = time;

            Instantiate(_parameters.CubePrefab, transform);
        }
    }
}
