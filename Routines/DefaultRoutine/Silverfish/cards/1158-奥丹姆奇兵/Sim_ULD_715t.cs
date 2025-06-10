namespace HREngine.Bots
{
	class Sim_ULD_715t : SimTemplate //* 灾祸狂刀 Plagued Knife
	{
		//<b>Poisonous</b>
		//<b>剧毒</b>
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_715t);

			p.equipWeapon(weapon, ownplay);
		}

	}
}