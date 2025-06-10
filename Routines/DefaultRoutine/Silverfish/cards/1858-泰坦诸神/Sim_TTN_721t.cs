using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：0
	//Attach the Cannons!
	//加装火炮！
	//Gain +2/+1.Deal 4 damage to a random enemy.
	//获得+2/+1。随机对一个敌人造成4点伤害。
	class Sim_TTN_721t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            foreach (Minion m in p.ownMinions)
            {
                if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_721)
                {
                    m.Angr += 2;
                    m.Hp += 1;
                    p.DealDamageToRandomCharacter(true, 4);

                    // 选择一个随机友方随从重复此技能
                    List<Minion> possibleTargets = new List<Minion>(p.ownMinions);
                    possibleTargets.Remove(m); // 确保不会选择当前随从
                    if (possibleTargets.Count > 0)
                    {
                        Minion randomAlly = possibleTargets[p.getRandomNumber(0, possibleTargets.Count - 1)];
                        randomAlly.Angr += 2;
                        randomAlly.Hp += 1;

                        p.DealDamageToRandomCharacter(true, 4);
                    }
                }
            }
        }
    }
}
