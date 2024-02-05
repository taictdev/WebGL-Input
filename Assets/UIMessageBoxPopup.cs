using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMessageBoxPopup : MonoBehaviour
{
    [SerializeField] private Button _btnOke;
    [SerializeField] private Button _btnClear;
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TextMeshProUGUI _tmpText;

    private void Awake()
    {
        _btnOke.onClick.AddListener(OnClickOke);
        _btnClear.onClick.AddListener(OnClickClear);
    }

    private void OnClickClear()
    {
        _tmpText.text = "";
        _inputField.text = "";
    }

    private void OnClickOke()
    {
        _tmpText.text = _inputField.text.Replace("\\n", System.Environment.NewLine);
    }
}