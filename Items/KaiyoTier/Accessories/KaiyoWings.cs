using t_test.Tiles;
using t_test.Items;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace t_test.Items.KaiyoTier.Accessories
{
    [AutoloadEquip(EquipType.Wings)]
    public class KaiyoWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Let Ra fly");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 10000;
            item.rare = 10  ;
            item.accessory = true;
        }
        //these wings use the same values as the solar wings
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 200;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.85f;
            ascentWhenRising = 0.30f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.135f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 9f;
            acceleration *= 2.5f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("KaiyoBar"), 15);
            recipe.AddIngredient(mod.ItemType("UmiEssence"), 10);
            recipe.AddIngredient(ItemID.SoulofFlight, 20);
            recipe.AddTile(mod.TileType("ForgeOfTheGods"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}