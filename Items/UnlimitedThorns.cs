using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedThorns : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Thorns Potion");
			Tooltip.SetDefault("Enemies hurt themselves.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Thorns, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.ThornsPotion, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
