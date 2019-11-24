using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace t_test.Projectiles
{
	public class DevastatorProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			// The following sets are only applicable to yoyo that use aiStyle 99.
			// YoyosLifeTimeMultiplier is how long in seconds the yoyo will stay out before automatically returning to the player. 
			// Vanilla values range from 3f(Wood) to 16f(Chik), and defaults to -1f. Leaving as -1 will make the time infinite.
			ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = -1f;
			// YoyosMaximumRange is the maximum distance the yoyo sleep away from the player. 
			// Vanilla values range from 130f(Wood) to 400f(Terrarian), and defaults to 200f
			ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 600f;
			// YoyosTopSpeed is top speed of the yoyo projectile. 
			// Vanilla values range from 9f(Wood) to 17.5f(Terrarian), and defaults to 10f
			ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 20f;
		}

		public override void SetDefaults() {
			projectile.extraUpdates = 0;
			projectile.width = 16;
			projectile.height = 16;
			// aiStyle 99 is used for all yoyos, and is Extremely suggested, as yoyo are extremely difficult without them
			projectile.aiStyle = 99;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.melee = true;
			projectile.scale = 1f;
		}

		public override void AI() {
			if (Main.rand.Next(100) == 0) {
				Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, 401, 450, projectile.knockBack, Main.myPlayer);
				projectile.friendly = true;
			}
		}

		public override void OnHitNPC(NPC npc, int damage, float knockback, bool crit) {
			Player owner = Main.player[projectile.owner];
			int rand = Main.rand.Next(10);
			if (rand < 0){
				npc.AddBuff(69, 180);
			}
			else if (rand == 0){
				owner.statLife += 15;
				owner.HealEffect(15, true);
			}
		}

		public override void PostAI() {
			if (Main.rand.NextFloat() < 0.3947369f)
			{
				Dust dust;
				// You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
				Vector2 position = Main.LocalPlayer.Center;
				dust = Terraria.Dust.NewDustDirect(position, 0, 0, 158, 0f, 0f, 184, new Color(255,150,0), 1.184211f);
			}
		}
	}
}
