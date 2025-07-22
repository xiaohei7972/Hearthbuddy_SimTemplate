using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：6 攻击力：4 生命值：5
	//Khaz'goroth
	//卡兹格罗斯
	//[x]<b>Titan</b>After this uses an ability, gain<b>Immune</b> this turn and attack arandom enemy minion.
	//<b>泰坦</b>在本随从使用一个技能后，在本回合中获得<b>免疫</b>并随机攻击一个敌方随从。
	class Sim_TTN_415 : SimTemplate
	{
        public override void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
            switch (titanAbilityNO)
            {
                case 1: // 泰坦锻造
                    var targetMinions = p.ownMinions.Where(m => m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_415).ToList();
                    targetMinions.ForEach(m =>
                    {
                        m.Angr += 2;
                        m.Hp += 2;
                    });
                    p.drawACard(CardDB.cardIDEnum.None, true); // 抽一张武器牌
                    break;

                case 2: // 升温回火
                    targetMinions = p.ownMinions.Where(m => m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_415).ToList();
                    targetMinions.ForEach(m =>
                    {
                        m.Angr += 5;
                    });
                    p.ownHero.tempAttack += 5; // 增加英雄攻击力
                    break;

                case 3: // 烈焰之心
                    targetMinions = p.ownMinions.Where(m => m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_415).ToList();
                    targetMinions.ForEach(m =>
                    {
                        m.Hp += 5;
                    });
                    p.ownHero.armor += 5; // 增加护甲值
                    break;

            }
        }
    }
}
