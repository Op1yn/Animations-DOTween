using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextAnimator : MonoBehaviour
{
    [SerializeField] private Text _text;

    private string _newText = "Новый текст";
    private string _addedText = " Добавлено";
    private string _hackedText = "Перебрал весь текст";


    private void Start()
    {
        AnimateText();
    }

    private void AnimateText()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_newText, 3)).Append(_text.DOText(_addedText, 3).SetRelative()).Append(_text.DOText(_hackedText, 6, true, ScrambleMode.Lowercase));
    }
}