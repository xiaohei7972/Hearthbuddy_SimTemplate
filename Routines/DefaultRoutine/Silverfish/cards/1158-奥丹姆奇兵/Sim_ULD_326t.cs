namespace HREngine.Bots
{
	class Sim_ULD_326t : SimTemplate //* 幻象之刃 Mirage Blade
	{
		//Your hero is <b>Immune</b> while attacking.
		//你的英雄在攻击时具有<b>免疫</b>。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_326t);
			p.equipWeapon(weapon, ownplay);
		}

	}
}