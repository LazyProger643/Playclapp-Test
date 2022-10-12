using UnityEngine;
using UnityEngine.UI;

public class ParametersValuesSetter : MonoBehaviour
{
    [SerializeField] private Parameters _parameters;
    [SerializeField] private InputField _spawnDelayField;
    [SerializeField] private InputField _movementSpeedField;
    [SerializeField] private InputField _movementDistanceField;

    private void Start()
    {
        _spawnDelayField.text = _parameters.SpawnDelay.ToString();
        _movementSpeedField.text = _parameters.MovementSpeed.ToString();
        _movementDistanceField.text = _parameters.MovementDistance.ToString();
    }
}
