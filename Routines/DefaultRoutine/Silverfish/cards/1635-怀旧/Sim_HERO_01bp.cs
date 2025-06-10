namespace HREngine.Bots
{
	class Sim_HERO_01bp : SimTemplate //* 全副武装！ Armor Up!
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, 2);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, 2);
            }
		}


	}
}