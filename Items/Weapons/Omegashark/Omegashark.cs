using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Messorem.Items.Weapons.Omegashark
{
	public class Omegashark : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() {
			item.damage = 120;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 10;	
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 30f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddIngredient(ItemID.Megashark);
			recipe.AddIngredient(ItemID.SDMG);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-20, 0);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = Main.rand.Next(new int[] { type, ProjectileID.GoldenBullet, ProjectileType.RocketI });
			return true;
		}
	}
}
