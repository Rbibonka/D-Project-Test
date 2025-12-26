using System;
using UnityEngine;

public interface IPlayer : IDisposable
{
    void TakeCurrentItem();

    void AddEquipment(Item item);

    void SetPosition(Vector3 position);
}