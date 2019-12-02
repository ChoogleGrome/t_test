using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace t_test.Items.AkaruiTier.Ores
{
	public class AkaruiOre : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Yea, it's bright");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 2;
		}
	}
}