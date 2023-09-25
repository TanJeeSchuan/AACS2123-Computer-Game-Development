using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : BaseCharacterBehaviour
{
    private Transform targetTransform;
    private Transform _aimmedTransform;
    private bool _flipX; 
    
    
    public GameObject aimmedGameObject;
    public bool flipWhenRotate;
    
    
    private new void Start()
    {
        base.Start();
        
        targetTransform = GameObject.FindGameObjectWithTag("Target").transform;
        _aimmedTransform = aimmedGameObject.transform;
    }

    void Update()
    {
        if (health.isDead() && !deathStatus)
        {
            deathStatus = true;
            kill();
        }
        


    }

    private void FixedUpdate()
    {
        if (!deathStatus)
        {
            move();
            
            if (flipWhenRotate)
            {
                switch ((- transform.position + _aimmedTransform.position).x)
                {
                    case < 0 when !_flipX:
                    case > 0 when _flipX:
                        flip();
                        break;
                }
            }
        }
    }

    public override void move()
    {
        characterMovement.move((- transform.position + _aimmedTransform.position).normalized);
    }

    public override void attack()
    {
        ;
    }

    public override void rotate()
    {
        ;
    }
    
    public void flip()
    {
        _flipX = !_flipX;
        _spriteRenderer.flipX = _flipX;

        // transform.localScale = Vector3.Scale(transform.localScale ,new Vector3(-1f, 1f, 1f));
    }
}
