using DG.Tweening;
using UnityEngine;

public class ChangingSize : MonoBehaviour
{
    [SerializeField] private float _sizeAxes;
    [SerializeField] private float _speed;

    void Start()
    {
        transform.DOScale(_sizeAxes, _speed);
    }
}