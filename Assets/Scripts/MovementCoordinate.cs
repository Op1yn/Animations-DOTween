using UnityEngine;
using DG.Tweening;

public class MovementCoordinate : MonoBehaviour
{
    [SerializeField] private Vector3 _finalDestination;
    [SerializeField] private float _speed;

    private void Start()
    {
        transform.DOMove(_finalDestination, _speed).SetLoops(-1);
    }
}