using UnityEngine;

public interface IItem
{
    ItemSocketParts ItemSocketPart { get; }

    void Setup(Transform parent);

    void Use();
}