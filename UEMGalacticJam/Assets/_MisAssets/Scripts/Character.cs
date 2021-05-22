using System.Collections;
using System.Collections.Generic;
using ExtraUnityEvents;
using UnityEngine;

public class Character : ICharacter
{
    public ReactiveProperty<Vector3> Position { get; set; }

    public Character(Vector3 _position)
    {
        Position = new ReactiveProperty<Vector3>(_position);
    }

}
