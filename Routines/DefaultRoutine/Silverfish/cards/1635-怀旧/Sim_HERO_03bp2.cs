namespace HREngine.Bots
{
	class Sim_HERO_03bp2 : SimTemplate //* 浸毒匕首 Poisoned Daggers
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_132_ROGUEt);
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }


	}
}