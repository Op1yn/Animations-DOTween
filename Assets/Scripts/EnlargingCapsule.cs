using UnityEngine;

public class EnlargingCapsule : AnimatedObject<TransformDOAnimator>
{
    [SerializeField] private TransformDOAnimator _animator;

    private void Start()
    {
        _animator.DoubleSize(transform);
    }
}