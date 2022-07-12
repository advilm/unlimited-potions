using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedShine : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Shine Potion");
			Tooltip.SetDefault("You give off light.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Shine, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.ShinePotion, 30);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}