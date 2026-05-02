using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour 
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Color _finalColor;
    [SerializeField] private float _speed;

    public void Start()
    {
        _renderer.material.DOColor(_finalColor, _speed);
    }
}