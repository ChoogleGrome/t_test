using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace t_test.Items.Shikyo_Tier.Ores
{
    public class Shikyo_Bar : ModItem 
    {
        public override void SetStaticDefaults() 
        {
            Tooltip.SetDefault("The bar of Death.");
        }

        public override void SetDefaults() 
        {
            item.width = 20;
            item.height = 50;

            item.maxStack = 999;
            item.value = 200;
            item.rare = 11;
        }

        public override void AddRecipes() 
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(mod.GetItem("Shikyo_Ore"), 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 20);

            recipe.AddRecipe();
        }
    }
}