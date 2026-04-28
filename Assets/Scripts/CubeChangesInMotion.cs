using UnityEngine;

public class CubeChangesInMotion : AnimatedObject<TransformDOAnimator>
{
    [SerializeField] private TransformDOAnimator _animator;

    private void Start()
    {
        _animator.DoubleSize(transform);
        _animator.MovementToCoordinate(transform);
        _animator.FlipX(transform);
    }
}