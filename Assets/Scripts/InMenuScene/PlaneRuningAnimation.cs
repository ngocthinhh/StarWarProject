using UnityEngine;

public class PlaneRuningAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        animator.Play("Move");
    }
}
