using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class PositiveNumberInputField : MonoBehaviour
{
    private InputField _inputField;

    private void Awake()
    {
        _inputField = GetComponent<InputField>();
        _inputField.onValidateInput += OnValidateInput;
    }

    private char OnValidateInput(string text, int charIndex, char addedChar)
    {
        if (float.TryParse(text + addedChar, NumberStyles.Float, CultureInfo.InvariantCulture, out float number))
            if (number >= 0)
                return addedChar;

        return '\0';
    }
}
