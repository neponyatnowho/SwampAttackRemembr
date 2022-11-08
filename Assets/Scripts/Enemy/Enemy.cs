using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _heath;
    [SerializeField] private int _reward;

    private Player _target;

    public Player Target => _target;


    public event UnityAction Dying;

    public void Init(Player Target)
    {
        _target = Target;
    }

    public void TakeDamage(int damage)
    {
        _heath -= damage;

        if(_heath <= 0)
        {
            Destroy(gameObject);
        }
    }

}
