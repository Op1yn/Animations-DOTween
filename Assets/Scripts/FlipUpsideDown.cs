using DG.Tweening;
using UnityEngine;

public class FlipUpsideDown : MonoBehaviour
{
    [SerializeField] private Vector3 _finalPosition;
    [SerializeField] private float _speed;

    void Start()
    {
        transform.DORotate(_finalPosition, _speed).SetLoops(-1);
    }
}