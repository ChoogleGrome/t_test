using Terraria.ID;
using Terraria.ModLoader;

namespace t_test.Items.Essences
{
	public class DakuEssence : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("It's too dark");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
		}
	}
}
