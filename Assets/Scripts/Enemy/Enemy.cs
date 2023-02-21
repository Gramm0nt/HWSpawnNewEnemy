using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player _target;

    public Player Target => _target;

    public void Init(Player target)
    {
        _target = target;
    }
}