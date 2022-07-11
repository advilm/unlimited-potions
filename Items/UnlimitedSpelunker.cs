using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedSpelunker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Spelunker Potion");
			Tooltip.SetDefault("See the treasures around you.\nUse the Settings UI to toggle the effect.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Spelunker, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SpelunkerPotion, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}