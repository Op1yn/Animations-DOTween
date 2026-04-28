using UnityEngine;
using DG.Tweening;

public class TransformDOAnimator : DOAnimator
{
    public void MovementToCoordinate(Transform transform)
    {
        transform.DOMove(new Vector3(0, 0, 0), 3).SetLoops(-1);
    }

    public void FlipX(Transform transform)
    {
        transform.DORotate(new Vector3(180, 0, 0), 10).SetLoops(-1);
    }

    public void DoubleSize(Transform transform)
    {
        transform.DOScale(2, 5);
    }
}