namespace HREngine.Bots
{
	class Sim_HERO_06bp2 : SimTemplate //* 恐怖变形 Dire Shapeshift
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.minionGetTempBuff(p.ownHero, 2, 0);
                p.minionGetArmor(p.ownHero,2);
            }
            else
            {
                p.minionGetTempBuff(p.enemyHero, 2, 0);
                p.minionGetArmor(p.enemyHero,2);
            }
        }


	}
}