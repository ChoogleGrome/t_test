using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace t_test.Projectiles.Shikyo_Bow_Proj
{
    public class Shikyo_Bow_Proj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shikyo Bow Projectile");
        }

        public override void SetDefaults()
        {
            projectile.arrow = true;
            projectile.width = 15;
            projectile.height = 5;
            projectile.friendly = true;
            projectile.maxPenetrate = 3;
            projectile.ignoreWater = true;
            projectile.noDropItem = true;
            projectile.aiStyle = 1;
        }
    }
}