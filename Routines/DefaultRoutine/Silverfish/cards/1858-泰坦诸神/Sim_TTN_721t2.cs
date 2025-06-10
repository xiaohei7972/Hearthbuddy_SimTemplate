using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：0
	//Maximize Defenses!
	//防御拉满！
	//Gain +3 Healthand <b>Elusive</b>.
	//获得+3生命值和<b>扰魔</b>。
	class Sim_TTN_721t2 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            foreach (Minion m in p.ownMinions)
            {
                if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_721)
                {
                    m.Hp += 3;
                    m.handcard.card.Elusive = true; // 扰魔

                    // 选择一个随机友方随从重复此技能
                    List<Minion> possibleTargets = new List<Minion>(p.ownMinions);
                    possibleTargets.Remove(m); // 确保不会选择当前随从
                    if (possibleTargets.Count > 0)
                    {
                        Minion randomAlly = possibleTargets[p.getRandomNumber(0, possibleTargets.Count - 1)];
                        randomAlly.Hp += 3;
                        randomAlly.handcard.card.Elusive = true; // 赋予相同的“扰魔”效果
                    }
                }
            }
        }
    }
}
