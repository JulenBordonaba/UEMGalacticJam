using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtraUnityEvents;

public interface ICharacter
{
    ReactiveProperty<Vector3> Position { get; set; }
}
