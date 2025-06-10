using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：0
	//Full Power!
	//动力全开！
	//Gain +1/+2.Draw a card.
	//获得+1/+2。抽一张牌。
	class Sim_TTN_721t1 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            foreach (Minion m in p.ownMinions)
            {
                if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_721)
                {
                    m.Angr += 1;
                    m.Hp += 2;
                    p.drawACard(CardDB.cardNameEN.unknown, true); // 抽一张牌

                    // 选择一个随机友方随从重复此技能
                    List<Minion> possibleTargets = new List<Minion>(p.ownMinions);
                    possibleTargets.Remove(m); // 确保不会选择当前随从
                    if (possibleTargets.Count > 0)
                    {
                        Minion randomAlly = possibleTargets[p.getRandomNumber(0, possibleTargets.Count - 1)];
                        randomAlly.Angr += 1;
                        randomAlly.Hp += 2;

                        p.drawACard(CardDB.cardNameEN.unknown, true); // 抽一张牌
                    }
                }
            }
        }
    }
}
