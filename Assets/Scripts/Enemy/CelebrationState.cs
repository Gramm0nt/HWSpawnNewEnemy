using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CelebrationState : State
{
    private const string CelebrateName = "Celebrate";

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.Play(CelebrateName);
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }
}