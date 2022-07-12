using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedInvisibility : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Invisibility Potion");
			Tooltip.SetDefault("'Cause it's useful for Truffle farming, apparently.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Invisibility, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.InvisibilityPotion, 30);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
