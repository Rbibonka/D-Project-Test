using UnityEngine;
using Zenject;

[DefaultExecutionOrder(-1)]
public class Bootstrap : MonoBehaviour
{
    [Inject]
    private IPlayer player;

    private void Awake()
    {
        //player.AddEquipment();
    }
}