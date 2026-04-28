using UnityEngine;
using DG.Tweening;

public class RendererDOAnimator : DOAnimator
{
    public void ChangeColor(Renderer renderer)
    {
        renderer.material.DOColor(Color.red, 6);
    }
}