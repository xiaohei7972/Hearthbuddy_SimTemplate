using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：6 攻击力：3 生命值：5
	//V-07-TR-0N Prime
	//终极V-07-TR-0N
	//[x]<b>T1T4N</b>This minion's abilitiesrepeat on another randomfriendly minion.
	//<b>泰钽</b>本随从的技能会在另一个随机友方随从身上重复。
	class Sim_TTN_721 : SimTemplate
	{
        public override void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
			switch(titanAbilityNO)
			{
                case 1: // 加装火炮！
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
                    break;

                case 2: // 动力全开！
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
                                p.drawACard(CardDB.cardNameEN.unknown, true); // 额外抽一张牌
                            }
                        }
                    }
                    break;

                case 3: // 防御拉满！
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
                    break;
            }
        }
    }
}
