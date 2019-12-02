using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace t_test.Items.Shikyo_Tier.Weapons
{
	public class Shikyo_Bow : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Bow of death");
            DisplayName.SetDefault("Shikyo Bow");
		}

		public override void SetDefaults() {
            item.damage = 200000;
			item.ranged = true;
			item.width = 20;
			item.height = 40;
			item.useTime = 11;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2;
			item.value = Item.sellPrice(1, 20, 0, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 16.5f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Shikyo_Bar"), 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly)
            {
                type = ProjectileType<Projectiles.Shikyo_Bow_Proj>();
            }

            int numberProjectiles = 5;

            for (int i = 0; i < numberProjectiles; i++)
            {
                position.Y = position.Y + (10 * i);
                Vector2 shootTo = new Vector2((Main.MouseWorld.X - position.X), (Main.MouseWorld.Y - position.Y));
                Projectile.NewProjectile(position.X, position.Y, shootTo.X, shootTo.Y, type, damage, knockBack, player.whoAmI);
            }

            return true;
        }
    }
}