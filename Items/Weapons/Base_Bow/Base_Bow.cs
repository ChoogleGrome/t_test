using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

<<<<<<< HEAD
namespace t_test.Items.Weapons {
=======
namespace Messorem.Items.Weapons {
>>>>>>> 94b969b8553ea2ee23c7b3125f02f408f6f2357c
    public class Base_Bow : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Base Bow Test");
            Tooltip.SetDefault("Big d lol");
        }

        public override void SetDefaults() {
            item.damage = 22;
            item.ranged = true;
            item.width = 12;
            item.height = 38;
            item.maxStack = 1;
            item.useTime = 28;
            item.useAnimation = 28;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 12000;
            item.rare = 2;
            item.UseSound = SoundID.Item5;
            item.noMelee = true;
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 10f;
            item.autoReuse = false;
        }
    }
}
