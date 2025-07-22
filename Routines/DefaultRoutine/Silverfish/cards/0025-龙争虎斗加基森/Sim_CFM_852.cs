using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_852 : SimTemplate //* 玉莲帮密探 Lotus Agents
//<b>Battlecry:</b> <b>Discover</b> a Druid, Rogue, or Shaman card.
//<b>战吼：</b><b>发现</b>一张德鲁伊、潜行者或萨满祭司卡牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.shieldbearer, m.own, true);
        }
    }
}