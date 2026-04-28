using UnityEngine;

public class MovingSphere : AnimatedObject<TransformDOAnimator>
{
    [SerializeField] private TransformDOAnimator _animator;

    private void Start()
    {
        _animator.MovementToCoordinate(transform);
    }
}