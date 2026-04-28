using UnityEngine;

public class RotatingCube : AnimatedObject<TransformDOAnimator>
{
    [SerializeField] private TransformDOAnimator _animator;

    private void Start()
    {
        _animator.FlipX(transform);
    }
}