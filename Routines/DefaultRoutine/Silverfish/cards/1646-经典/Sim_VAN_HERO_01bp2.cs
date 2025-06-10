namespace HREngine.Bots
{
	class Sim_VAN_HERO_01bp2 : SimTemplate //* 铜墙铁壁！ Tank Up!
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, 4);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, 4);
            }
		}

	}
}