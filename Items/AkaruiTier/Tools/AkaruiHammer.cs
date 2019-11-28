using t_test.Dusts;
using t_test.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace t_test.Items.AkaruiTier.Tools
{
	public class AkaruiHammer : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Light smasher");
		}

		public override void SetDefaults() {
			item.damage = 10;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.hammer = 75;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 1000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("AkaruiBar"), 10);
			recipe.AddIngredient(mod.GetItem("HikariEssence"), 5);
			recipe.AddTile(TileID.Anvils);
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
