using UnityEngine;

public class RecoloringCylinder : AnimatedObject<RendererDOAnimator>
{
    [SerializeField] private RendererDOAnimator _animator;
    [SerializeField] private Renderer _renderer;

    private void Start()
    {
        _animator.ChangeColor(_renderer);
    }
}