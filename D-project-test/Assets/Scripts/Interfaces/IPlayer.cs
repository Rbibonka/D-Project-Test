using System;
using UnityEngine;

public interface IPlayer : IDisposable
{
    void TakeNextItem();

    void AddEquipment(Item item);

    void SetPosition(Vector3 position);
}