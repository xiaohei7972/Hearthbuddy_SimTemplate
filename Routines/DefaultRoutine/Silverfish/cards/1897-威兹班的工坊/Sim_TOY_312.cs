using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：4 生命值：4
	//Nostalgic Gnome
	//恋旧的侏儒
	//[x]<b>Miniaturize</b><b>Rush</b>. After this minion dealsexact lethal damage on yourturn, draw a card.
	//<b>微缩</b><b>突袭</b>。在本随从在你的回合中造成了刚好消灭目标的伤害后，抽一张牌。
	class Sim_TOY_312 : SimTemplate
	{
        public override void onMinionGotDmgTrigger(Playfield p, Minion triggerEffectMinion, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            // 仅当是己方随从攻击并且是恋旧的侏儒时触发
            if (triggerEffectMinion.own && triggerEffectMinion.handcard.card.cardIDenum == CardDB.cardIDEnum.TOY_312)
            {
                // 检查所有敌方随从是否刚好被致命伤害击杀
                foreach (Minion m in p.enemyMinions)
                {
                    int damageTaken = m.maxHp - m.Hp; // 计算随从受到的总伤害
                    if (m.Hp <= 0 && damageTaken == m.maxHp)
                    {
                        // 如果随从受到了刚好致命伤害，触发抽牌效果
                        p.drawACard(CardDB.cardIDEnum.None, triggerEffectMinion.own);
                        break;
                    }
                }
            }
        }

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理微缩效果：抽一张衍生物牌
            CardDB.Card miniaturizedCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_312t); // 假设衍生物牌ID为 TOY_312t
            if (miniaturizedCard != null)
            {
                p.drawACard(miniaturizedCard.cardIDenum, ownplay, true);
            }
        }

    }
}
