namespace HREngine.Bots
{
    class Sim_DRG_023 : SimTemplate //* 空中炮艇 Skybarge
    {
        //[x]After you summon aPirate, deal 2 damageto a random enemy.
        //在你召唤一个海盗后，随机对一个敌人造成2点伤害。
        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if ((TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.PIRATE && triggerEffectMinion.own == summonedMinion.own)
            {
                Minion target = null;

                if (triggerEffectMinion.own)
                {
                    target = p.getEnemyCharTargetForRandomSingleDamage(2);
                }
                else
                {
                    target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); //damage the Highest (pessimistic)
                    if (target == null) target = p.ownHero;
                }
                p.minionGetDamageOrHeal(target, 2, true);
            }
        }

    }
}