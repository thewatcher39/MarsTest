using System.Security.Cryptography;
using UnityEngine;

namespace WatcherHome
{
    public class OreHandler : Triggerable
    {
        [SerializeField] private Ore _ore;
        
        protected override void TriggerEnter(Collider other)
        {
            OnPlayerTrigger(other);
            Destroy(gameObject);
        }

        protected override void TriggerExit(Collider other)
        {
            
        }

        private void OnPlayerTrigger(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Player player))
            {
                player.playerInventory.AddOre(_ore);
            }
        }
    }
}