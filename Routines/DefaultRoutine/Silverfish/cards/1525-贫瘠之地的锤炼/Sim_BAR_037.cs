using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_037 : SimTemplate //* 战歌驯兽师 Warsong Wrangler
	{
        //[x]<b>Battlecry:</b> <b>Discover</b> aBeast in your deck. Giveall copies of it +2/+1 <i>(wherever_they_are)</i>.
        //<b>战吼：</b>从你的牌库中<b>发现</b>一张野兽牌。使其所有的复制获得+2/+1<i>（无论它们在哪）</i>。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 首先判断小飞兔在吗
            bool foundRabbit = false;
            // 遍历卡组
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                if(deckCard == CardDB.cardIDEnum.SCH_133)
                {
                    foundRabbit = true;
                }
            }
            if (foundRabbit)
            {
                p.drawACard(CardDB.cardIDEnum.SCH_133, true, true);
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.cardIDenum == CardDB.cardIDEnum.SCH_133)
                    {
                        hc.addattack += 2;
                        hc.addHp += 1;
                        p.anzOwnExtraAngrHp += 6;
                    }
                    foreach (Minion m in p.ownMinions)
                    {
                        if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.SCH_133)
                        {
                            p.minionGetBuffed(m, 2, 1);
                        }
                    }
                }
            }else
            {
                p.drawACard(CardDB.cardIDEnum.DMF_087, true, true);
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.cardIDenum == CardDB.cardIDEnum.DMF_087)
                    {
                        hc.addattack += 2;
                        hc.addHp += 1;
                        p.anzOwnExtraAngrHp += 3;
                    }
                    foreach (Minion m in p.ownMinions)
                    {
                        if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.DMF_087)
                        {
                            p.minionGetBuffed(m, 2, 1);
                        }
                    }
                }
            }
        }
    }
}
