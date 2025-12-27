using UnityEngine;
using Zenject;

[DefaultExecutionOrder(-1)]
public class Bootstrap : MonoBehaviour
{
    [SerializeField]
    private Transform startSpawnPoint;

    [Inject]
    private IPlayer player;

    [Inject]
    private IItemsCreator itemsCreator;

    private void Awake()
    {
        player.AddEquipment(itemsCreator.CreateWeapon());
        player.AddEquipment(itemsCreator.CreateParachute());
        player.AddEquipment(itemsCreator.CreateJatPack());

        player.SetPosition(startSpawnPoint.position);
    }

    private void OnDestroy()
    {
        player.Dispose();
    }
}