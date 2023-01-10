using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] private ArcherFactory _archerFactory;
    [SerializeField] private WarriorFactory _warriorFactory;

    public void ArcherButton()
    {
        var prefab = _archerFactory.GetNewInstance();
    }
    public void WarriorButton()
    {
        var prefab = _warriorFactory.GetNewInstance();
    }
}
