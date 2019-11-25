using t_test.Dusts;
using t_test.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace t_test.Items.Nori_Tier.Tools
{
	public class NoriPickaxe : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Uses the heat of the sun");
		}

		public override void SetDefaults() {
			item.damage = 30;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.pick = 235;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("NoriBar"), 15);
			recipe.AddIngredient(mod.ItemType("FlareEssence"), 10);
			recipe.AddTile(mod.GetTile("ForgeOfTheGods"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(10)) {
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustType<Sparkle>());
			}
		}
	}
}