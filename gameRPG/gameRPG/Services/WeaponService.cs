using gameRPG.Models;
using System.Collections.Generic;
using System.Linq;
using gameRPG.Models;
namespace gameRPG.Services
{
    public class WeaponService
{

        public event Action OnChange;

        public void NotifyStateChanged() => OnChange?.Invoke();


        public List<ChickenWeapon> Weapons { get; private set; }
        public ChickenWeapon EquippedWeapon { get; private set; }

    public WeaponService()
    {
        Weapons = new List<ChickenWeapon>
        {
            new ChickenWeapon { Id = 1, Name = "Wooden Sword", ImageUrl = "woodensword.png" },
            new ChickenWeapon { Id = 2, Name = "Enchanted Wooden Sword", ImageUrl = "enchantedsword.gif" },
            new ChickenWeapon { Id = 3, Name = "Diamond Sword", ImageUrl = "diamondsword.png" }
        };
            if (Weapons.Count > 0)
            {
                EquippedWeapon = Weapons[0];
            }
        }

    public void EquipWeapon(ChickenWeapon weapon)
    {
        EquippedWeapon = weapon;
        
    }
    }
}