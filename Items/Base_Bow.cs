using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items {
    public class Base_Bow : ModItem {
        public override void SetStaticDefaults() {
            Tooltip.SetDefault("Base Bow Test");
        }

        public override void SetDefaults() {
            item.damage = 204;
            item.knockBack = 3;
            item.ranged = true;

            item.width = 10;
            item.height = 40;

            item.maxStack = 1;

            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.UseSound = SoundID.Item5;
            item.noMelee = true;

            
            item.value = 120000;
            item.rare = 12;
            
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 1f;
            item.autoReuse = true;
        }
        
        public override void AddRecipies() {
            ModRecipe recipe = new ModRecipe(mod)
            recipe.AddIngredient(ItemID.)
        }
    }
}