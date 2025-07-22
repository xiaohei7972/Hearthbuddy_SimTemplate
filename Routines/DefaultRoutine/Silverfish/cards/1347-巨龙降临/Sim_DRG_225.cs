namespace HREngine.Bots
{
	class Sim_DRG_225 : SimTemplate //* 空中飞爪 Sky Claw
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_225t); 
		//Your other Mechshave +1 Attack.<b>Battlecry:</b> Summon two 1/1 Microcopters.
		//你的其他机械获得+1攻击力。<b>战吼：</b>召唤两个1/1的微型旋翼机。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.callKid(kid, own.zonepos - 1, own.own);
            p.callKid(kid, own.zonepos, own.own);
        }
		public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnSouthseacaptain++;
                foreach (Minion m in p.ownMinions)
                {
                    if((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL && own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 1, 0);
                }
            }
            else
            {
                p.anzEnemySouthseacaptain++;
                foreach (Minion m in p.enemyMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL && own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 1, 0);
                }
            }

        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnSouthseacaptain--;
                foreach (Minion m in p.ownMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL && own.entitiyID != m.entitiyID) p.minionGetBuffed(m, -1, 0);
                }
            }
            else
            {
                p.anzEnemySouthseacaptain--;
                foreach (Minion m in p.enemyMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL && own.entitiyID != m.entitiyID) p.minionGetBuffed(m, -1, 0);
                }
            }
        }


	}
}