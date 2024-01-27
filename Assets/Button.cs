using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] private string _incomeText;

    private Color _backGroundColor = Color.black;
    private Color _textColor = Color.white;

    public TMP_Text _text;
    
    public void OnButtonClick()
    {
        Image image = GetComponent<Image>();

        image.color = _backGroundColor;
        _text.color = _textColor;
        _text.text = _incomeText;
    }
}
