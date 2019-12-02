using Terraria.ID;
using Terraria.ModLoader;

namespace t_test.Items.Shikyo_Tier.Weapons
{
	public class Shikyo_Bow : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Bow of death");
            DisplayName.SetDefault("Shikyo Bow");
		}

		public override void SetDefaults() {
            item.damage = 20000;
			item.ranged = true;
			item.width = 20;
			item.height = 40;
			item.useTime = 3;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 0f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Shikyo_Bar"), 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}