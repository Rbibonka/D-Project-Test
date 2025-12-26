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
        //foreach (var item in items)
        //{
        //    var tempItem = Instantiate(item.ItemPrefab);

        //    tempItem.InitializeBase(item.Name, item.ItemSocketParts);
        //    tempItem.gameObject.SetActive(false);

        //    player.AddEquipment(tempItem);
        //}

        player.AddEquipment(itemsCreator.CreateWeapon());
        player.AddEquipment(itemsCreator.CreateParachute());
        player.AddEquipment(itemsCreator.CreateJatPack());

        player.TakeNextItem();
        player.SetPosition(startSpawnPoint.position);
    }

    private void OnDestroy()
    {
        player.Dispose();
    }
}