using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace t_test.Items.Shikyo_Tier.Ore 
{
    public class Shikyo_Ore : ModItem 
    {
        public override void SetStaticDefaults() 
        {
            Tooltip.SetDefault("The ore of Death.");
        }

        public override void SetDefaults() 
        {
            item.width = 20;
            item.height = 20;

            item.maxStack = 999;
            item.value = 30;
            item.rare = 4;
        }

        public override void AddRecipes() 
        {
            ModRecipe recipe = new ModRecipe(mod);

            // Test Recipe
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 20);

            recipe.AddRecipe();
        }
    }
}