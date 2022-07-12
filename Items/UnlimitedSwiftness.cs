using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedSwiftness : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Swiftness Potion");
			Tooltip.SetDefault("So fast, wow.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Swiftness, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SwiftnessPotion, 30);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
