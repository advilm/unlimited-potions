using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedIchor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Ichor Flask");
			Tooltip.SetDefault("Your attacks inflict ichor.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Ichor, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FlaskofIchor, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
