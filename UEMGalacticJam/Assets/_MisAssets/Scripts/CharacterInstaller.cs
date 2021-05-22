using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInstaller : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private PositionObserver _positionObserver;
    private Character _character;

    private void Awake()
    {
        _character = new Character(transform.position);
    }

}
