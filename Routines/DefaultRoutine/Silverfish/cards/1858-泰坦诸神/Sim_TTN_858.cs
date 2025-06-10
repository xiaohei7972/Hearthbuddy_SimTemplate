using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：7 攻击力：1 生命值：8
	//Amitus, the Peacekeeper
	//维和者阿米图斯
	//<b>Titan</b><b>Taunt</b>. Your minionscan't take more than 2_damage at a time.
	//<b>泰坦</b><b>嘲讽</b>。你的随从每次受到伤害不会超过2点。
	class Sim_TTN_858 : SimTemplate
	{
        public override void onAuraStarts(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.ownAmitusThePeacekeeper = true;
            }
            else
            {
                p.enemyAmitusThePeacekeeper = true;
            }
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.ownAmitusThePeacekeeper = false;
            } 
            else
            {
                p.enemyAmitusThePeacekeeper = false;
            }
        }

        public override void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
            switch (titanAbilityNO)
            {
                case 1: // 增援
                    p.drawACard(CardDB.cardIDEnum.None, true, true);
                    p.drawACard(CardDB.cardIDEnum.None, true, true);
                    var buffedCards = p.owncards.Skip(Math.Max(0, p.owncards.Count - 2)).ToList();
                    buffedCards.ForEach(handCard =>
                    {
                        handCard.card.Attack = 2;
                        handCard.card.Health = 2;
                        handCard.manacost = 2;
                    });
                    break;

                case 2: // 强化
                    p.ownMinions.ForEach(m =>
                    {
                        m.Angr += 2;
                        m.Hp += 2;
                    });
                    break;

                case 3: // 平静
                    p.enemyMinions.ForEach(m =>
                    {
                        m.Angr = 2;
                        m.Hp = 2;
                    });
                    break;

            }
        }
    }
}
