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
			recipe.AddIngredient(mod.GetItem("FlareEssence"), 10);
			recipe.AddIngredient(mod.GetItem("WetEssence"), 10);
			recipe.AddIngredient(mod.GetItem("SpaceEssence"), 10);
			recipe.AddIngredient(mod.GetItem("DarkEssence"), 10);
			recipe.AddIngredient(mod.GetItem("LightEssence"), 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();

			// recipe #2
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarCraftingStation);
			recipe.AddIngredient(ItemID.MythrilAnvil);
			recipe.AddIngredient(ItemID.AdamantiteForge);
			recipe.AddIngredient(mod.GetItem("FlareEssence"), 10);
			recipe.AddIngredient(mod.GetItem("WetEssence"), 10);
			recipe.AddIngredient(mod.GetItem("SpaceEssence"), 10);
			recipe.AddIngredient(mod.GetItem("DarkEssence"), 10);
			recipe.AddIngredient(mod.GetItem("LightEssence"), 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();

			// recipe #3
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarCraftingStation);
			recipe.AddIngredient(ItemID.OrichalcumAnvil);
			recipe.AddIngredient(ItemID.TitaniumForge);
			recipe.AddIngredient(mod.GetItem("FlareEssence"), 10);
			recipe.AddIngredient(mod.GetItem("WetEssence"), 10);
			recipe.AddIngredient(mod.GetItem("SpaceEssence"), 10);
			recipe.AddIngredient(mod.GetItem("DarkEssence"), 10);
			recipe.AddIngredient(mod.GetItem("LightEssence"), 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();

			// recipe #4
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarCraftingStation);
			recipe.AddIngredient(ItemID.OrichalcumAnvil);
			recipe.AddIngredient(ItemID.AdamantiteForge);
			recipe.AddIngredient(mod.GetItem("FlareEssence"), 10);
			recipe.AddIngredient(mod.GetItem("WetEssence"), 10);
			recipe.AddIngredient(mod.GetItem("SpaceEssence"), 10);
			recipe.AddIngredient(mod.GetItem("DarkEssence"), 10);
			recipe.AddIngredient(mod.GetItem("LightEssence"), 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}