using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace t_test.Items.Placeable
{
	public class ForgeOfTheGods : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("When the gods need crafting");
		}

		public override void SetDefaults() {
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = TileType<Tiles.ForgeOfTheGods>();
		}

		public override void AddRecipes() {
			// recipe #1
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarCraftingStation);
			recipe.AddIngredient(ItemID.MythrilAnvil);
			recipe.AddIngredient(ItemID.TitaniumForge);
			recipe.AddIngredient(mod.ItemType("FlareEssence"), 10);
			recipe.AddIngredient(mod.ItemType("WetEssence"), 10);
			recipe.AddIngredient(mod.ItemType("SpaceEssence"), 10);
			recipe.AddIngredient(mod.ItemType("DarkEssence"), 10);
			recipe.AddIngredient(mod.ItemType("LightEssence"), 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}