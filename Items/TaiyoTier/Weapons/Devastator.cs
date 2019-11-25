using t_test.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace t_test.Items.TaiyoTier.Weapons
{
	public class Devastator : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Ra's true power");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults() {
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 25;
			item.shootSpeed = 16f;
			item.knockBack = 2.5f;
			item.damage = 250;
			item.rare = 10;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(gold: 2);
			item.shoot = ProjectileType<DevastatorProjectile>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("TaiyoBar"), 20);
			recipe.AddIngredient(mod.GetItem("KasaiEssence"), 10);
			recipe.AddIngredient(ItemID.Terrarian);
			recipe.AddTile(mod.TileType("ForgeOfTheGods"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
