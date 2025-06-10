namespace HREngine.Bots
{
	class Sim_DRG_256 : SimTemplate //* 灭龙弩炮 Dragonbane
	{
		//After you use your Hero Power, deal 5 damage to a random enemy.
		//在你使用你的英雄技能后，随机对一个敌人造成5点伤害。
		public override void onInspire(Playfield p, Minion m, bool own)
        {
			Minion target = null;

            if (m.own)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(5);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, searchmode.searchLowestHP); //(pessimistic)
                if (target == null) target = p.ownHero;
            }
            p.minionGetDamageOrHeal(target, 5);
        }


	}
}