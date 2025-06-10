namespace HREngine.Bots
{
	class Sim_HERO_03bp : SimTemplate//* 匕首精通 Dagger Mastery
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_082);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }


	}
}