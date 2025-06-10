namespace HREngine.Bots
{
	class Sim_ULD_215 : SimTemplate //* 被缚的魔像 Wrapped Golem
	{
        //[x]<b>Reborn</b>At the end of your turn,summon a 1/1 Scarabwith <b>Taunt</b>.
        //<b>复生</b>在你的回合结束时，召唤一只1/1并具有<b>嘲讽</b>的甲虫。
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            CardDB.Card scarab = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_215t);
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int place = triggerEffectMinion.zonepos;
                p.callKid(scarab, place, triggerEffectMinion.own);
            }
        }

    }
}