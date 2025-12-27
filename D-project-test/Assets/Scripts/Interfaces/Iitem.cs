using UnityEngine;

public interface IItem
{
    ItemSocketParts ItemSocketPart { get; }

    void SetToGrabPoint(Transform parent);

    void Use();
}