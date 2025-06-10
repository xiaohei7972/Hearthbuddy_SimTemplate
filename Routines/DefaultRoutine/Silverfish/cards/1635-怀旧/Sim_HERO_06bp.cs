namespace HREngine.Bots
{
	class Sim_HERO_06bp : SimTemplate //* 变形 Shapeshift
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.minionGetTempBuff(p.ownHero, 1, 0);
                p.minionGetArmor(p.ownHero,1);
            }
            else
            {
                p.minionGetTempBuff(p.enemyHero, 1, 0);
                p.minionGetArmor(p.enemyHero,1);
            }
        }


	}
}